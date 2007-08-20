using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Text.RegularExpressions;
using System.Net;

namespace IMDBTest {

    [TestClass]
    public class ImdbTest {

        private const string HEADER_NAME_RESULTS = "IMDb Name  Search";
        private const string HEADER_TITLE_RESULTS = "IMDb Title  Search";

        private const string URL_NAME_SEARCH = "http://imdb.com/find?s=nm&q=";
        private const string URL_TITLE_SEARCH = "http://imdb.com/find?s=tt&q=";
        private const string URL_ALL_SEARCH = "http://imdb.com/find?s=all&q=";
        private const string URL_NAME_PAGE = "http://imdb.com/name/nm";
        private const string URL_TITLE_PAGE = "http://imdb.com/title/tt";

        private const string REGEX_ANCHOR_TITLE = "<a\\s+?href=\\\"/title/tt(?<TitleCode>\\d{7}).*?>(?<Title>.+?)</a>";
        private const string REGEX_ANCHOR_NAME = "<a\\s+?href=\\\"/name/nm(?<NameCode>\\d{7}).*?>(?<Name>.+?)</a>";

        [TestMethod]
        public void TitleRegex() {
            Match match = _titleAnchorRegex.Match("<li>(8.00) -<a href=\"/title/tt0107048/\">Groundhog Day</a>(1993)<h6>Next US airings:</h6>");

            string expected = "Groundhog Day";
            string actual = match.Groups["Title"].Value;

            WriteResult(expected, actual);
            Assert.AreEqual(expected, actual);

            expected = "0107048";
            actual = match.Groups["TitleCode"].Value;

            WriteResult(expected, actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TitleLinksFromFilmo() {
            Regex titleAnchorRegex = new Regex(REGEX_ANCHOR_TITLE, RegexOptions.IgnoreCase | RegexOptions.Multiline);

            string nameCode = "0000195"; //Bill Murray

            string page = GetPage(URL_NAME_PAGE, nameCode);

            MatchCollection matches = titleAnchorRegex.Matches(page);

            foreach (Match match in matches) {
                Console.WriteLine(match.Value);
            }

        }

        [TestMethod]
        public void NameLinksFromMovie() {
            Regex nameAnchorRegex = new Regex(REGEX_ANCHOR_NAME, RegexOptions.IgnoreCase | RegexOptions.Multiline);

            string titleCode = "0362270"; //The Life Aquatic

            string page = GetPage(URL_TITLE_PAGE, titleCode);

            MatchCollection matches = nameAnchorRegex.Matches(page);

            foreach (Match match in matches) {
                Console.WriteLine(match.Value);
            }

        }

        #region Util

        private static string GetPage(string pageUrl, string code) {
            WebClient webClient = new WebClient();
            string page;
            try {
                page = webClient.DownloadString(pageUrl + code);
            }
            catch (WebException ex) {
                //Connection Error.
                throw ex;
            }
            return page;
        }

        private void WriteResult(string expected, string actual) {
            Console.WriteLine("Should be:\t{0}\tIs:\t{1}", expected, actual);
        }

        #endregion
    }
}

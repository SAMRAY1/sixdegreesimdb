using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Collections;
using System.Web;
using System.Text.RegularExpressions;
using SixDegrees.Properties;

namespace SixDegrees
{

    public class IMDBTools
    {

        public const string HEADER_NAME_RESULTS = "IMDb Name  Search";
        public const string HEADER_TITLE_RESULTS = "IMDb Title  Search";

        public const string URL_NAME_SEARCH = Resources.Url_Search_Name;
        public const string URL_TITLE_SEARCH = Resources.Url_Search_Title;
        public const string URL_ALL_SEARCH = Resources.Url_Search_All;
        public const string URL_NAME_PAGE = Resources.Url_Page_Name;
        public const string URL_TITLE_PAGE = Resources.Url_Page_Title;

        #region Utility

        private static string GetPage(string pageUrl, string query) {
            WebClient webClient = new WebClient();
            string page;
            try {
                page = webClient.DownloadString(pageUrl + query.Replace(' ', '+'));
            }
            catch (WebException ex) {
                //Connection Error.
                //TODO: Trigger onError event which is attached to and handled by application.
                throw ex;
            }
            return page;
        }

        #endregion

        public static string GetNameCode(string actorName)
        {
            string page = GetPage(URL_NAME_SEARCH, actorName);

            int indNameCode, indDivFinder;
            if (page.Contains(HEADER_NAME_RESULTS))
            {
                //Name search has taken us to the IMDb Name Search results page.
                indDivFinder = page.IndexOf("Popular Names");
            }
            else
            {
                //Name search has taken us directly to the actor page.
                indDivFinder = page.IndexOf("name-top-links");
            }
            indNameCode = page.IndexOf("/nm", indDivFinder) + 3;

            return page.Substring(indNameCode, 7);
        }

        public static string GetMovieCode(string movieName)
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(URL_TITLE_SEARCH + movieName.Replace(' ', '+'));

            int indTitleCode, indDivFinder;
            if (page.Contains(HEADER_TITLE_RESULTS))
            {
                //Title search has taken us to the IMDb Title Search results page.
                indDivFinder = page.IndexOf("Popular Titles");
            }
            else
            {
                //Title search has taken us directly to the movie page.
                indDivFinder = page.IndexOf("title-top-links");
            }
            indTitleCode = page.IndexOf("/tt", indDivFinder) + 3;

            return page.Substring(indTitleCode, 7);
        }

        public static Hashtable GetMovies(string nameCode)
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(URL_NAME_PAGE + nameCode);

            Hashtable titles = new Hashtable();

            int indFilmoStart = page.IndexOf("<ol>", page.IndexOf("filmo"));

            int indCurrent = indFilmoStart;
            string strChunk = "";
            while (!strChunk.Contains("</ol>"))
            {
                indCurrent = page.IndexOf("<li>", indCurrent);
                int indChunkEnd = page.IndexOf("</li>", indCurrent);
                strChunk = page.Substring(indCurrent + 4, indChunkEnd - indCurrent - 4);
                string strTitleCode = strChunk.Substring(strChunk.IndexOf("/tt") + 3, 7);
                int indTitleStart = strChunk.IndexOf("\">", strChunk.IndexOf(strTitleCode)) + 2;
                string strMovieTitle = strChunk.Substring(indTitleStart, strChunk.IndexOf("</a>", indTitleStart) - indTitleStart);

                //titles.Add(strTitleCode, strMovieTitle.Replace("&#34;", ""));
                titles.Add(strTitleCode, HttpUtility.HtmlDecode(strMovieTitle));

                //Move chunk window ahead 10 characters to check for </ol> in while condition.
                indCurrent = page.IndexOf("</li>", indCurrent);
                strChunk = page.Substring(indCurrent, 10);
            }

            return titles;
        }

        public static Hashtable GetCast(string movieCode)
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(URL_TITLE_PAGE + movieCode);

            int indStart = page.IndexOf("<table class=\"cast\">") + "<table class=\"cast\">".Length;
            int indEnd = page.IndexOf("</table>", indStart);// + "</table>".Length;
            string html = page.Substring(indStart, indEnd - indStart);

            Hashtable cast = new Hashtable();
            int indCurr;
            while (html.Contains("<td class=\"nm\">"))
            {
                string code, name;
                int indNameEnd;

                indCurr = html.IndexOf("<td class=\"nm\">") + "<td class=\"nm\">".Length;
                indCurr = html.IndexOf("/nm", indCurr) + "/nm".Length;
                code = html.Substring(indCurr, 7);
                indCurr = html.IndexOf(">", indCurr) + ">".Length;
                indNameEnd = html.IndexOf("<", indCurr);
                name = html.Substring(indCurr, indNameEnd - indCurr);

                cast.Add(code, name);

                html = html.Substring(indNameEnd, html.Length - indNameEnd);
            }

            return cast;
        }
    }
}

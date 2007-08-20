using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Web.UI.WebControls;

namespace SixDegrees {
    public partial class SelectResult : Form {

        private string _choice;
        public string Choice {
            get { return _choice; }
        }
        
        public SelectResult() {
            InitializeComponent();
        }
        
        public SelectResult(Hashtable choices) {
            foreach (string key in choices.Keys) {
                ListItem item = new ListItem((string)choices[key], key);
                choicesLB.Items.Add(item);
            }
        }

        private void chooseB_Click(object sender, EventArgs e) {
            _choice = ((ListItem)choicesLB.SelectedValue).Value;
            
            Close();
        }
    }
}
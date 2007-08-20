using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SixDegrees {
    public partial class TransparentPanel : Panel {

        override protected CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                //cp.ExStyle |= 0x20;
                return cp;
            }
        }

        public TransparentPanel() {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e) {
        }
    }
}

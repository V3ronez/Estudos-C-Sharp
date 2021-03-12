using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Componentes {
    public partial class F_LinkLabel : Form {
        public F_LinkLabel() {
            InitializeComponent();

            ll_mult.Links.Add(0, 6,"www.google.com.br");
            ll_mult.Links.Add(7, 7, "www.youtube.com");
            ll_mult.Links.Add(15, 3, "www.youtube.com");
        }

        private void ll_twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://twitter.com");
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("calc.exe");
        }

        private void ll_mult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(e.Link.LinkData.ToString());
        }
    }
}

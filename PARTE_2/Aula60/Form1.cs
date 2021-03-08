using System;
using System.Windows.Forms;

namespace Aula60 {
    public partial class F_principal : Form {
        public F_principal() {
            InitializeComponent();
        }

        private void F_principal_Load(object sender, EventArgs e) {

        }

        private void btn_test_Click(object sender, EventArgs e) {

            lb_seraQueTesta.Text = tb_name.Text;
        }
    }
}

using System;
using System.Windows.Forms;

namespace Componentes {
    public partial class F_CbChild : Form {
        public F_checkBox Fcb;
        public F_CbChild() {
            InitializeComponent();

            try {
                Fcb = Application.OpenForms["F_checkBox"] as F_checkBox;
                cb_carro.Checked = Fcb.cb_carro.Checked;
                cb_aviao.Checked = Fcb.cb_aviao.Checked;
                cb_navio.Checked = Fcb.cb_navio.Checked;
                cb_onibus.Checked = Fcb.cb_onibus.Checked;
            } catch {
                MessageBox.Show("Erro ao abrir o formulário.");
            }
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e) {
            Fcb.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e) {
            Fcb.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e) {
            Fcb.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e) {
            Fcb.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}

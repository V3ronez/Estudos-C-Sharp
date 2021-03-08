using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Componentes {
    public partial class F_checkBox : Form {

        List<CheckBox> transp = new List<CheckBox>();
        public F_checkBox() {
            InitializeComponent();
            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);

        }

        private void btn_transp_marc_Click(object sender, EventArgs e) {
            String txt = "";
            foreach (CheckBox t in transp) {
                if(t.Checked) {
                    txt += t.Text + ",";
                }
            }

            MessageBox.Show(txt);
        }

        private void cb_laranja_CheckedChanged(object sender, EventArgs e) {
            if (cb_laranja.Checked) {
                MessageBox.Show("Só o W do GP né velho?!");
            }
        }

        private void abrir_filho_Click(object sender, EventArgs e) {
            F_CbChild f_CbChild = new F_CbChild();
            f_CbChild.ShowDialog();
        }
    }
}

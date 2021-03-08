using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Componentes {
    public partial class F_CheckedListBox : Form {
        public F_CheckedListBox() {
            InitializeComponent();
        }

        private void btn_MostrarSelect_Click(object sender, EventArgs e) {
            string txt = "";

            foreach (String t in clb_transp.CheckedItems) {
                txt += t + ", ";
            }
            clb_transp.CheckedItems[0].ToString();

            MessageBox.Show(txt);
        }

        private void btn_LimparList_Click(object sender, EventArgs e) {
            clb_transp.Items.Clear();
        }

        private void btn_Reset_Click(object sender, EventArgs e) {
            clb_transp.Items.Clear();

            List<string> List_transp = new List<string>();

            List_transp.Add("Carro");
            List_transp.Add("Aviâo");
            List_transp.Add("Navio");
            List_transp.Add("Ônibus");
            List_transp.Add("Trem");

            clb_transp.Items.AddRange(List_transp.ToArray());
        }

        private void btn_AddToList_Click(object sender, EventArgs e) {
            if (tb_NovoTransp.Text != "") {
                clb_transp.Items.Add(tb_NovoTransp.Text);
                tb_NovoTransp.Clear();
            } else {
                MessageBox.Show("Adicione um veículo");
                tb_NovoTransp.Focus();
            }

        }
    }
}

using System;
using System.Windows.Forms;

namespace Componentes {
    public partial class F_ComboBox : Form {
        public F_ComboBox() {
            InitializeComponent();
        }

        private void btn_MostrarSelected_Click(object sender, EventArgs e) {
            if (cb_transportes.Text == "") {
                MessageBox.Show("Selecione um item");
            } else {
                MessageBox.Show(cb_transportes.Text);

            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e) {
            cb_transportes.Items.Clear();

        }

        private void cb_ResetElem_Click(object sender, EventArgs e) {
            cb_transportes.Items.Clear();

            cb_transportes.Items.Add("Carro");
            cb_transportes.Items.Add("Avião");
            cb_transportes.Items.Add("Navio");
            cb_transportes.Items.Add("Ônibus");
            cb_transportes.Items.Add("Trem");
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e) {
            tb_NovoTransp.Text = cb_transportes.Text;
        }

        private void btn_AddNovoTransp_Click(object sender, EventArgs e) {
            string txt = tb_NovoTransp.Text;

            if (txt != "") {
                if (cb_transportes.FindString(tb_NovoTransp.Text) < 0)
                    cb_transportes.Items.Add(tb_NovoTransp.Text);
            }
        }
    }
}

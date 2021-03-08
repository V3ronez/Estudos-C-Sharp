using System;
using System.Windows.Forms;

namespace Componentes {
    public partial class Form_Principal : Form {

        public int num;
        public Form_Principal() {
            InitializeComponent();
            num = 12;
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if (tb_veiculo.Text == "") {
                MessageBox.Show("Digite um veículo");
                tb_veiculo.Focus();
                return;
            }
            tb_listaVei.Text += tb_veiculo.Text + ", ";
            tb_veiculo.Clear();
            tb_veiculo.Focus();

        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            tb_listaVei.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e) {
            Form_veiculos form_Veiculos = new Form_veiculos(tb_listaVei.Text, this);
            form_Veiculos.ShowDialog();

        }

        private void btn_varNum_Click(object sender, EventArgs e) {
            MessageBox.Show(num.ToString());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) {
            F_checkBox f_checkbox = new F_checkBox();
            f_checkbox.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }
    }
}

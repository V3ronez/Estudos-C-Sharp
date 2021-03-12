using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Componentes {
    public partial class F_ListBox : Form {

        List<String> Carros = new List<string>();
        public F_ListBox() {
            InitializeComponent();
            Carros.Add("Clio");
            Carros.Add("Golf");
            Carros.Add("Focus");

            lb_Carros.DataSource = Carros;
        }

        private void AtualizaLb(ListBox lb, List<string>l) {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void btn_Add_Click(object sender, EventArgs e) {
            if (tb_Carro.Text == "") {
                MessageBox.Show("Digite um carro!");
                tb_Carro.Focus();
            } else {
                Carros.Add(tb_Carro.Text);
                tb_Carro.Clear();
                AtualizaLb(lb_Carros, Carros);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e) {
            Carros.RemoveAt(lb_Carros.SelectedIndex);
            AtualizaLb(lb_Carros, Carros);
        }

        private void btn_Obter_Click(object sender, EventArgs e) {
            tb_Carro.Text = Carros[lb_Carros.SelectedIndex];
        }
    }
}

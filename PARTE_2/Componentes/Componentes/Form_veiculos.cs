using System;
using System.Windows.Forms;

namespace Componentes {
    public partial class Form_veiculos : Form {
        Form_Principal fp;
        public Form_veiculos(String v, Form_Principal f) {
            InitializeComponent();

            tb_ListaVeiculos.Text = v;

            fp = f;

        }

        private void Form_veiculos_FormClosed(object sender, FormClosedEventArgs e) {
            fp.tb_listaVei.Text = tb_ListaVeiculos.Text;
        }
    }
}

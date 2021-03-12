using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes {
    public partial class F_DateTimePicker : Form {
        public F_DateTimePicker() {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e) {
            tb_data.Text = dtp_data.Text;
            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setarData_Click(object sender, EventArgs e) {
            int day, month, year;
            day = Int32.Parse(tb_dia.Text);
            month = Int32.Parse(tb_mes.Text);
            year = Int32.Parse(tb_ano.Text);

            DateTime dateTime = new DateTime(year, month, day);

            dtp_data.Value = dateTime;
        }

        private void btn_hoje_Click(object sender, EventArgs e) {
            dtp_data.Value = DateTime.Today; 
        }
    }
}

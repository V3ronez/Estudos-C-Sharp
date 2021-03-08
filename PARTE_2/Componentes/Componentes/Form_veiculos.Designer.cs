
namespace Componentes {
    partial class Form_veiculos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ListaVeiculos
            // 
            this.tb_ListaVeiculos.Location = new System.Drawing.Point(12, 12);
            this.tb_ListaVeiculos.Multiline = true;
            this.tb_ListaVeiculos.Name = "tb_ListaVeiculos";
            this.tb_ListaVeiculos.Size = new System.Drawing.Size(577, 426);
            this.tb_ListaVeiculos.TabIndex = 0;
            // 
            // Form_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.tb_ListaVeiculos);
            this.Name = "Form_veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ListaVeiculos;
    }
}
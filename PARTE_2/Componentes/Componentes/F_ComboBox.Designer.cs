
namespace Componentes {
    partial class F_ComboBox {
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelected = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.cb_ResetElem = new System.Windows.Forms.Button();
            this.tb_NovoTransp = new System.Windows.Forms.TextBox();
            this.btn_AddNovoTransp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(229, 23);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_MostrarSelected
            // 
            this.btn_MostrarSelected.Location = new System.Drawing.Point(266, 13);
            this.btn_MostrarSelected.Name = "btn_MostrarSelected";
            this.btn_MostrarSelected.Size = new System.Drawing.Size(227, 23);
            this.btn_MostrarSelected.TabIndex = 1;
            this.btn_MostrarSelected.Text = "Mostrar selecionado";
            this.btn_MostrarSelected.UseVisualStyleBackColor = true;
            this.btn_MostrarSelected.Click += new System.EventHandler(this.btn_MostrarSelected_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(266, 42);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(227, 23);
            this.btn_Limpar.TabIndex = 2;
            this.btn_Limpar.Text = "Limpar Elementos";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // cb_ResetElem
            // 
            this.cb_ResetElem.Location = new System.Drawing.Point(266, 71);
            this.cb_ResetElem.Name = "cb_ResetElem";
            this.cb_ResetElem.Size = new System.Drawing.Size(227, 23);
            this.cb_ResetElem.TabIndex = 3;
            this.cb_ResetElem.Text = "Resetar Elementos";
            this.cb_ResetElem.UseVisualStyleBackColor = true;
            this.cb_ResetElem.Click += new System.EventHandler(this.cb_ResetElem_Click);
            // 
            // tb_NovoTransp
            // 
            this.tb_NovoTransp.Location = new System.Drawing.Point(266, 142);
            this.tb_NovoTransp.Name = "tb_NovoTransp";
            this.tb_NovoTransp.Size = new System.Drawing.Size(227, 23);
            this.tb_NovoTransp.TabIndex = 4;
            // 
            // btn_AddNovoTransp
            // 
            this.btn_AddNovoTransp.Location = new System.Drawing.Point(266, 171);
            this.btn_AddNovoTransp.Name = "btn_AddNovoTransp";
            this.btn_AddNovoTransp.Size = new System.Drawing.Size(227, 23);
            this.btn_AddNovoTransp.TabIndex = 5;
            this.btn_AddNovoTransp.Text = "Add Novo Transporte";
            this.btn_AddNovoTransp.UseVisualStyleBackColor = true;
            this.btn_AddNovoTransp.Click += new System.EventHandler(this.btn_AddNovoTransp_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 463);
            this.Controls.Add(this.btn_AddNovoTransp);
            this.Controls.Add(this.tb_NovoTransp);
            this.Controls.Add(this.cb_ResetElem);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_MostrarSelected);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button cb_ResetElem;
        private System.Windows.Forms.TextBox tb_NovoTransp;
        private System.Windows.Forms.Button btn_AddNovoTransp;
        private System.Windows.Forms.Button btn_MostrarSelected;
    }
}
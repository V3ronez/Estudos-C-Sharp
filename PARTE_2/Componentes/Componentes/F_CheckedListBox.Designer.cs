
namespace Componentes {
    partial class F_CheckedListBox {
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
            this.clb_transp = new System.Windows.Forms.CheckedListBox();
            this.btn_MostrarSelect = new System.Windows.Forms.Button();
            this.btn_LimparList = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_AddToList = new System.Windows.Forms.Button();
            this.tb_NovoTransp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transp
            // 
            this.clb_transp.FormattingEnabled = true;
            this.clb_transp.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transp.Location = new System.Drawing.Point(12, 12);
            this.clb_transp.Name = "clb_transp";
            this.clb_transp.Size = new System.Drawing.Size(120, 238);
            this.clb_transp.TabIndex = 0;
            // 
            // btn_MostrarSelect
            // 
            this.btn_MostrarSelect.Location = new System.Drawing.Point(227, 12);
            this.btn_MostrarSelect.Name = "btn_MostrarSelect";
            this.btn_MostrarSelect.Size = new System.Drawing.Size(141, 34);
            this.btn_MostrarSelect.TabIndex = 1;
            this.btn_MostrarSelect.Text = "Mostrar seleção";
            this.btn_MostrarSelect.UseVisualStyleBackColor = true;
            this.btn_MostrarSelect.Click += new System.EventHandler(this.btn_MostrarSelect_Click);
            // 
            // btn_LimparList
            // 
            this.btn_LimparList.Location = new System.Drawing.Point(227, 52);
            this.btn_LimparList.Name = "btn_LimparList";
            this.btn_LimparList.Size = new System.Drawing.Size(141, 30);
            this.btn_LimparList.TabIndex = 2;
            this.btn_LimparList.Text = "Limpar Lista";
            this.btn_LimparList.UseVisualStyleBackColor = true;
            this.btn_LimparList.Click += new System.EventHandler(this.btn_LimparList_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(227, 88);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(141, 30);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Resetar Lista";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_AddToList
            // 
            this.btn_AddToList.Location = new System.Drawing.Point(203, 212);
            this.btn_AddToList.Name = "btn_AddToList";
            this.btn_AddToList.Size = new System.Drawing.Size(196, 34);
            this.btn_AddToList.TabIndex = 4;
            this.btn_AddToList.Text = "Adicionar novo transp";
            this.btn_AddToList.UseVisualStyleBackColor = true;
            this.btn_AddToList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // tb_NovoTransp
            // 
            this.tb_NovoTransp.Location = new System.Drawing.Point(203, 183);
            this.tb_NovoTransp.Name = "tb_NovoTransp";
            this.tb_NovoTransp.Size = new System.Drawing.Size(196, 23);
            this.tb_NovoTransp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NovoTransp);
            this.Controls.Add(this.btn_AddToList);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_LimparList);
            this.Controls.Add(this.btn_MostrarSelect);
            this.Controls.Add(this.clb_transp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transp;
        private System.Windows.Forms.Button btn_MostrarSelect;
        private System.Windows.Forms.Button btn_LimparList;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_AddToList;
        private System.Windows.Forms.TextBox tb_NovoTransp;
        private System.Windows.Forms.Label label1;
    }
}
﻿
namespace Componentes {
    partial class F_checkBox {
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_transp_marc = new System.Windows.Forms.Button();
            this.cb_laranja = new System.Windows.Forms.CheckBox();
            this.abrir_filho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(12, 26);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(55, 19);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(12, 51);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(56, 19);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(12, 76);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(57, 19);
            this.cb_navio.TabIndex = 2;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(12, 101);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(64, 19);
            this.cb_onibus.TabIndex = 3;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_transp_marc
            // 
            this.btn_transp_marc.Location = new System.Drawing.Point(202, 22);
            this.btn_transp_marc.Name = "btn_transp_marc";
            this.btn_transp_marc.Size = new System.Drawing.Size(164, 23);
            this.btn_transp_marc.TabIndex = 4;
            this.btn_transp_marc.Text = "Transportes marcados";
            this.btn_transp_marc.UseVisualStyleBackColor = true;
            this.btn_transp_marc.Click += new System.EventHandler(this.btn_transp_marc_Click);
            // 
            // cb_laranja
            // 
            this.cb_laranja.AutoSize = true;
            this.cb_laranja.Location = new System.Drawing.Point(12, 192);
            this.cb_laranja.Name = "cb_laranja";
            this.cb_laranja.Size = new System.Drawing.Size(64, 19);
            this.cb_laranja.TabIndex = 5;
            this.cb_laranja.Text = "Laranja";
            this.cb_laranja.UseVisualStyleBackColor = true;
            this.cb_laranja.CheckedChanged += new System.EventHandler(this.cb_laranja_CheckedChanged);
            // 
            // abrir_filho
            // 
            this.abrir_filho.Location = new System.Drawing.Point(202, 51);
            this.abrir_filho.Name = "abrir_filho";
            this.abrir_filho.Size = new System.Drawing.Size(164, 23);
            this.abrir_filho.TabIndex = 6;
            this.abrir_filho.Text = "Abri filho";
            this.abrir_filho.UseVisualStyleBackColor = true;
            this.abrir_filho.Click += new System.EventHandler(this.abrir_filho_Click);
            // 
            // F_checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 542);
            this.Controls.Add(this.abrir_filho);
            this.Controls.Add(this.cb_laranja);
            this.Controls.Add(this.btn_transp_marc);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_checkBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_transp_marc;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_navio;
        public System.Windows.Forms.CheckBox cb_onibus;
        public System.Windows.Forms.CheckBox cb_laranja;
        private System.Windows.Forms.Button abrir_filho;
    }
}
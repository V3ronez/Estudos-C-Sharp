
namespace Componentes {
    partial class F_LinkLabel {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.ll_twitter = new System.Windows.Forms.LinkLabel();
            this.ll_mult = new System.Windows.Forms.LinkLabel();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(13, 32);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(217, 23);
            this.tb_nome.TabIndex = 1;
            // 
            // ll_twitter
            // 
            this.ll_twitter.AutoSize = true;
            this.ll_twitter.Location = new System.Drawing.Point(13, 62);
            this.ll_twitter.Name = "ll_twitter";
            this.ll_twitter.Size = new System.Drawing.Size(42, 15);
            this.ll_twitter.TabIndex = 2;
            this.ll_twitter.TabStop = true;
            this.ll_twitter.Text = "Twitter";
            this.ll_twitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_twitter_LinkClicked);
            // 
            // ll_mult
            // 
            this.ll_mult.AutoSize = true;
            this.ll_mult.Location = new System.Drawing.Point(170, 62);
            this.ll_mult.Name = "ll_mult";
            this.ll_mult.Size = new System.Drawing.Size(104, 15);
            this.ll_mult.TabIndex = 3;
            this.ll_mult.TabStop = true;
            this.ll_mult.Text = "Google-Twitter-sla";
            this.ll_mult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_mult_LinkClicked);
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(79, 62);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(70, 15);
            this.ll_calculadora.TabIndex = 4;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 445);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.ll_mult);
            this.Controls.Add(this.ll_twitter);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.LinkLabel ll_twitter;
        private System.Windows.Forms.LinkLabel ll_mult;
        private System.Windows.Forms.LinkLabel ll_calculadora;
    }
}
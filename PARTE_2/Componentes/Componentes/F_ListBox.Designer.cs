
namespace Componentes {
    partial class F_ListBox {
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
            this.lb_Carros = new System.Windows.Forms.ListBox();
            this.tb_Carro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Carros
            // 
            this.lb_Carros.FormattingEnabled = true;
            this.lb_Carros.ItemHeight = 15;
            this.lb_Carros.Location = new System.Drawing.Point(12, 12);
            this.lb_Carros.Name = "lb_Carros";
            this.lb_Carros.Size = new System.Drawing.Size(120, 184);
            this.lb_Carros.TabIndex = 0;
            // 
            // tb_Carro
            // 
            this.tb_Carro.Location = new System.Drawing.Point(154, 33);
            this.tb_Carro.Name = "tb_Carro";
            this.tb_Carro.Size = new System.Drawing.Size(100, 23);
            this.tb_Carro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carro";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(154, 62);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(154, 91);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(100, 23);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Remover";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(154, 120);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(100, 23);
            this.btn_Obter.TabIndex = 5;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 457);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Carro);
            this.Controls.Add(this.lb_Carros);
            this.Name = "F_ListBox";
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Carros;
        private System.Windows.Forms.TextBox tb_Carro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Obter;
    }
}
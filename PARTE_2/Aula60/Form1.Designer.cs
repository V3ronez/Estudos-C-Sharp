
namespace Aula60
{
    partial class F_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_test = new System.Windows.Forms.Button();
            this.lb_seraQueTesta = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_test.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_test.ForeColor = System.Drawing.Color.Red;
            this.btn_test.Location = new System.Drawing.Point(236, 56);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(186, 39);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "ok?";
            this.btn_test.UseVisualStyleBackColor = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // lb_seraQueTesta
            // 
            this.lb_seraQueTesta.AutoSize = true;
            this.lb_seraQueTesta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_seraQueTesta.Location = new System.Drawing.Point(201, 132);
            this.lb_seraQueTesta.Name = "lb_seraQueTesta";
            this.lb_seraQueTesta.Size = new System.Drawing.Size(270, 28);
            this.lb_seraQueTesta.TabIndex = 1;
            this.lb_seraQueTesta.Text = "Será que ta testando mesmo?";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(219, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(214, 23);
            this.tb_name.TabIndex = 2;
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 492);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_seraQueTesta);
            this.Controls.Add(this.btn_test);
            this.Name = "F_principal";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.F_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label lb_seraQueTesta;
        private System.Windows.Forms.TextBox tb_name;
    }
}


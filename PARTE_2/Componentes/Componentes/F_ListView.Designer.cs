
namespace Componentes {
    partial class F_ListView {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
            this.lv_produto = new System.Windows.Forms.ListView();
            this.col_ID = new System.Windows.Forms.ColumnHeader();
            this.col_produto = new System.Windows.Forms.ColumnHeader();
            this.col_qtde = new System.Windows.Forms.ColumnHeader();
            this.col_preco = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lv_produto
            // 
            this.lv_produto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_produto,
            this.col_qtde,
            this.col_preco});
            this.lv_produto.FullRowSelect = true;
            this.lv_produto.HideSelection = false;
            this.lv_produto.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_produto.Location = new System.Drawing.Point(32, 12);
            this.lv_produto.MultiSelect = false;
            this.lv_produto.Name = "lv_produto";
            this.lv_produto.Size = new System.Drawing.Size(576, 97);
            this.lv_produto.TabIndex = 0;
            this.lv_produto.UseCompatibleStateImageBehavior = false;
            this.lv_produto.View = System.Windows.Forms.View.Details;
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 40;
            // 
            // col_produto
            // 
            this.col_produto.Text = "produto";
            this.col_produto.Width = 250;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quantidade";
            this.col_qtde.Width = 80;
            // 
            // col_preco
            // 
            this.col_preco.Text = "preco";
            this.col_preco.Width = 120;
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 451);
            this.Controls.Add(this.lv_produto);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_produto;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
    }
}
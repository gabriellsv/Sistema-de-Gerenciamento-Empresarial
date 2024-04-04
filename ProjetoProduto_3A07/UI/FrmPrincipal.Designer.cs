namespace ProjetoProduto_3A07.UI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inializarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemTipos = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inializarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inializarToolStripMenuItem
            // 
            this.inializarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemCategoria,
            this.MnuItemCliente,
            this.MnuItemFornecedor,
            this.MnuItemProduto,
            this.MnuItemTipos,
            this.loginToolStripMenuItem});
            this.inializarToolStripMenuItem.Name = "inializarToolStripMenuItem";
            this.inializarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.inializarToolStripMenuItem.Text = "Inializar";
            // 
            // MnuItemCategoria
            // 
            this.MnuItemCategoria.Name = "MnuItemCategoria";
            this.MnuItemCategoria.Size = new System.Drawing.Size(180, 22);
            this.MnuItemCategoria.Text = "Categoria";
            this.MnuItemCategoria.Click += new System.EventHandler(this.MnuItemCategoria_Click);
            // 
            // MnuItemCliente
            // 
            this.MnuItemCliente.Name = "MnuItemCliente";
            this.MnuItemCliente.Size = new System.Drawing.Size(180, 22);
            this.MnuItemCliente.Text = "Cliente";
            this.MnuItemCliente.Click += new System.EventHandler(this.MnuItemCliente_Click);
            // 
            // MnuItemFornecedor
            // 
            this.MnuItemFornecedor.Name = "MnuItemFornecedor";
            this.MnuItemFornecedor.Size = new System.Drawing.Size(180, 22);
            this.MnuItemFornecedor.Text = "Fornecedor";
            this.MnuItemFornecedor.Click += new System.EventHandler(this.MnuItemFornecedor_Click);
            // 
            // MnuItemProduto
            // 
            this.MnuItemProduto.Name = "MnuItemProduto";
            this.MnuItemProduto.Size = new System.Drawing.Size(180, 22);
            this.MnuItemProduto.Text = "Produto";
            this.MnuItemProduto.Click += new System.EventHandler(this.MnuItemProduto_Click);
            // 
            // MnuItemTipos
            // 
            this.MnuItemTipos.Name = "MnuItemTipos";
            this.MnuItemTipos.Size = new System.Drawing.Size(180, 22);
            this.MnuItemTipos.Text = "Tipo de Usuário";
            this.MnuItemTipos.Click += new System.EventHandler(this.MnuItemTipos_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inializarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCategoria;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCliente;
        private System.Windows.Forms.ToolStripMenuItem MnuItemFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MnuItemProduto;
        private System.Windows.Forms.ToolStripMenuItem MnuItemTipos;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}
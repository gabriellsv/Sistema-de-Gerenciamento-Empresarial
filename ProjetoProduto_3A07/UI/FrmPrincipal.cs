using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProduto_3A07.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MnuItemCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria obj = new FrmCategoria();
            obj.ShowDialog();
        }

        private void MnuItemCliente_Click(object sender, EventArgs e)
        {
            FrmCliente obj = new FrmCliente();
            obj.ShowDialog();
        }

        private void MnuItemFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor obj = new FrmFornecedor();
            obj.ShowDialog();
        }

        private void MnuItemProduto_Click(object sender, EventArgs e)
        {
            FrmProduto obj = new FrmProduto();
            obj.ShowDialog();
        }

        private void MnuItemTipos_Click(object sender, EventArgs e)
        {
            FrmTipoUsuario obj = new FrmTipoUsuario();
            obj.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin obj = new FrmLogin();
            obj.ShowDialog();
        }
    }
}

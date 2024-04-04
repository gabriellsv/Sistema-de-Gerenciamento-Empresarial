using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ProjetoProduto_3A07.UI;


namespace ProjetoProduto_3A07
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string emailUsuario = txtUsuario.Text;
            string senhaUsuario = txtSenha.Text;

            ClienteBLL objClienteBLL = new ClienteBLL();

            if (objClienteBLL.ValidarUsuario(emailUsuario) == false)
            {
                MessageBox.Show("ATENÇÃO. Usuário não existe.");
            }
            else if (objClienteBLL.ValidarUsuario(emailUsuario, senhaUsuario))
            {
                FrmPrincipal objTela = new FrmPrincipal();
                objTela.ShowDialog();
            }
            else
            {
                MessageBox.Show("A senha está INCORRETA.");
            }
        }
    }
}

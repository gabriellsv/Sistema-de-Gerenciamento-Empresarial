using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using ProjetoProduto_3A07.BLL;

namespace ProjetoProduto_3A07.UI
{
    public partial class FrmTipoUsuario : Form
    {
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {
            CarregarGridTipoUsuario();
        }

        TipoUsuarioBLL objTipoUsuarioBLL = new TipoUsuarioBLL();
        TipoUsuarioDTO objTipoUsuarioDTO = new TipoUsuarioDTO();

        public void CarregarGridTipoUsuario()
        {
            gridTipoUsuario.DataSource = objTipoUsuarioBLL.ListarTiposUsuarios();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                objTipoUsuarioDTO.Descricao = txtDescricao.Text;
                objTipoUsuarioBLL.InserirTipoUsuario(objTipoUsuarioDTO);
                MessageBox.Show("Tipo de Usuário cadastrado");
                CarregarGridTipoUsuario();
                LimparComponentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.\n" + ex.Message);
            }

        }

        private void gridTipoUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gridTipoUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = gridTipoUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void LimparComponentes()
        {
            txtId.Clear();
            txtDescricao.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                objTipoUsuarioDTO.Id = int.Parse(txtId.Text);
                objTipoUsuarioBLL.ExcluirTipoUsuario(objTipoUsuarioDTO);
                MessageBox.Show("O tipo de usuário foi Excluída");
                CarregarGridTipoUsuario();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione um tipo de usuário para excluir.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "") //Existe um ID selecionado?
            {
                objTipoUsuarioDTO.Id = int.Parse(txtId.Text);
                objTipoUsuarioDTO.Descricao = txtDescricao.Text;

                objTipoUsuarioBLL.AlterarTipoUsuario(objTipoUsuarioDTO);
                MessageBox.Show("Os dados da CATEGORIA cadastrado foram alterados com sucesso.");
                CarregarGridTipoUsuario();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione um tipo de usuário para atualizar os dados.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
    }
}

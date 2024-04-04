using BLL;
using DTO;
using ProjetoProduto_3A07.BLL;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        public void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregarGridCliente();
            CarregarTipoUsuario();
        }

        ClienteBLL objClienteBLL = new ClienteBLL();
        ClienteDTO objClienteDTO = new ClienteDTO();
        TipoUsuarioBLL objTipoBLL = new TipoUsuarioBLL();

        private void CarregarGridCliente()
        {
            gridCliente.DataSource = objClienteBLL.ListarClientes();
        }

        private void CarregarTipoUsuario()  //responsável por preencher o tipo de usuário
        {
            cbxTbl.DataSource = objTipoBLL.ListarTiposUsuarios();
            cbxTbl.DisplayMember = "descricao";
            cbxTbl.ValueMember = "id";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtId.Text == "")
                {
                    objClienteDTO.Nome = txtNome.Text;
                    objClienteDTO.Endereco = txtEndereco.Text;
                    objClienteDTO.Uf = cbxUf.Text;
                    objClienteDTO.Telefone = txtTelefone.Text;
                    objClienteDTO.Email = txtEmail.Text;
                    objClienteDTO.Senha = txtSenha.Text;
                    objClienteDTO.Tbl_tipousuario_id = int.Parse(cbxTbl.SelectedValue.ToString());
                    // Outro modo de fazer: objClienteDTO.Tbl_tipousuario_id = Convert.ToInt32(cbxTbl.SelectedValue);

                    objClienteBLL.InserirCliente(objClienteDTO);
                    MessageBox.Show("Cliente cadastrado");
                    CarregarGridCliente();
                    LimparComponentes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.\n" + ex.Message);
            }

        }

        private void LimparComponentes()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            cbxUf.Text = null;
            txtTelefone.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cbxTbl.Text = null;
        }

        private void gridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gridCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = gridCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = gridCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxUf.Text = gridCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelefone.Text = gridCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = gridCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSenha.Text = gridCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbxTbl.SelectedValue = gridCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                objClienteDTO.Id = int.Parse(txtId.Text);
                objClienteBLL.ExcluirCliente(objClienteDTO);
                MessageBox.Show("O Cliente foi Excluído");
                CarregarGridCliente();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "") //Existe um ID selecionado?
            {
                objClienteDTO.Id = int.Parse(txtId.Text);
                objClienteDTO.Nome = txtNome.Text;
                objClienteDTO.Endereco = txtEndereco.Text;
                objClienteDTO.Uf = cbxUf.Text;
                objClienteDTO.Telefone = txtTelefone.Text;
                objClienteDTO.Email = txtEmail.Text;
                objClienteDTO.Senha = txtSenha.Text;
                objClienteDTO.Tbl_tipousuario_id = Convert.ToInt32(cbxTbl.SelectedValue);

                objClienteBLL.AlterarCliente(objClienteDTO);
                MessageBox.Show("Os dados do CLIENTE cadastrado foram alterados com sucesso.");
                CarregarGridCliente();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para atualizar os dados.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }

        private void txtPesquisa_TextChanged (object sender, EventArgs e)
        {
            string variavel = "";

            if (rbNome.Checked)
                variavel = "nome";
            else if (rbEndereco.Checked)
                variavel = "endereco";
            else if (rbTelefone.Checked)
                variavel = "telefone";
            else if (rbEmail.Checked)
                variavel = "email";
            else
                variavel = "nome";

            gridCliente.DataSource = objClienteBLL.ListarClientes(variavel, txtPesquisa.Text); ;

            //string query = $"SELECT * FROM tbl_cliente WHERE nome like '%{txtPesquisa.Text}%'";
            //gridCliente.DataSource = objClienteBLL.ListarClientes(query);
        }
    }
}

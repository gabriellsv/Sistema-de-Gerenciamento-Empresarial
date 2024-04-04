using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoProduto_3A07.UI
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(Object sender, EventArgs e)
        {
            CarregarGridFornecedor();
        }

        FornecedorBLL objFornecedorBLL = new FornecedorBLL();
        FornecedorDTO objFornecedorDTO = new FornecedorDTO();

        //Queremos preencher o DataGridView com os dados obtidos do select (BLL)

        public void CarregarGridFornecedor()
        {
            gridFornecedor.DataSource = objFornecedorBLL.ListarFornecedores();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {                              
                objFornecedorDTO.Nome = txtNome.Text;
                objFornecedorDTO.Email = txtEmail.Text;
                objFornecedorDTO.Telefone = txtTelefone.Text;

                objFornecedorBLL.InserirFornecedor(objFornecedorDTO);
                MessageBox.Show("Fornecedor cadastrado");
                CarregarGridFornecedor();
                LimparComponentes();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO.\n" + ex.Message);
            }
        }
        
        private void LimparComponentes()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }

        private void gridFornecedor_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            txtId.Text = gridFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = gridFornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = gridFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = gridFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                objFornecedorDTO.Id = int.Parse(txtId.Text);
                objFornecedorBLL.ExcluirFornecedor(objFornecedorDTO);
                MessageBox.Show("O Fornecedor foi Excluído");
                CarregarGridFornecedor();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para excluir.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text !="") //Existe um ID selecionado?
            {
                objFornecedorDTO.Id = int.Parse(txtId.Text);
                objFornecedorDTO.Nome = txtNome.Text;
                objFornecedorDTO.Email = txtEmail.Text;
                objFornecedorDTO.Telefone = txtTelefone.Text;

                objFornecedorBLL.AlterarFornecedor(objFornecedorDTO);
                MessageBox.Show("Os dados do FORNECEDOR cadastrado foram alterados com sucesso.");
                CarregarGridFornecedor();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para atualizar os dados.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
    }
}

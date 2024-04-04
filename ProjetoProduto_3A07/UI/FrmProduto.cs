using BLL;
using DTO;
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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CarregarGridProduto();
        }

        ProdutoBLL objProdutoBLL = new ProdutoBLL();
        ProdutoDTO objProdutoDTO = new ProdutoDTO();
        CategoriaBLL objCategoriaBLL = new CategoriaBLL();
        FornecedorBLL objFornecedorBLL = new FornecedorBLL();

        private void CarregarGridProduto()
        {
            gridProduto.DataSource = objProdutoBLL.ListarProdutos();
            CarregarCategoria();
            CarregarFornecedor();
        }

        private void CarregarCategoria()  //responsável por preencher o tipo de usuário
        {
            cbxTbl_C.DataSource = objCategoriaBLL.ListarCategorias();
            cbxTbl_C.DisplayMember = "descricao";
            cbxTbl_C.ValueMember = "id";
        }

        private void CarregarFornecedor()  //responsável por preencher o tipo de usuário
        {
            cbxTbl_F.DataSource = objFornecedorBLL.ListarFornecedores();
            cbxTbl_F.DisplayMember = "nome";
            cbxTbl_F.ValueMember = "id";
        }

        private void btnGravar_Click(object sender, EventArgs e)
         {
             try
             {
                 objProdutoDTO.Descricao = txtDescricao.Text;
                 objProdutoDTO.Preco = double.Parse(txtPreco.Text);
                 objProdutoDTO.Quantidade = int.Parse(txtQuantidade.Text);
                 objProdutoDTO.Peso = double.Parse(txtPeso.Text);
                 objProdutoDTO.Tbl_categoria_id = int.Parse(cbxTbl_C.SelectedValue.ToString());
                 objProdutoDTO.Tbl_fornecedor_id = int.Parse(cbxTbl_F.SelectedValue.ToString());

                 objProdutoBLL.InserirProduto(objProdutoDTO);
                 MessageBox.Show("Produto cadastrado");
                 CarregarGridProduto();
                 LimparComponentes();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("ERRO.\n" + ex.Message);
             }
         }

        private void LimparComponentes()
        {
            txtDescricao.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtPeso.Clear();
            cbxTbl_C.Text = null;
            cbxTbl_F.Text = null;

        }

        private void gridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gridProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = gridProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = gridProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantidade.Text = gridProduto.Rows[e.RowIndex].Cells[3].Value.ToString(); 
            txtPeso.Text = gridProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxTbl_C.SelectedValue = gridProduto.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbxTbl_F.SelectedValue = gridProduto.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                objProdutoDTO.Id = int.Parse(txtId.Text);
                objProdutoBLL.ExcluirProduto(objProdutoDTO);
                MessageBox.Show("O Cliente foi Excluído");
                CarregarGridProduto();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "") //Existe um ID selecionado?
            {
                objProdutoDTO.Id = int.Parse(txtId.Text);
                objProdutoDTO.Descricao = txtDescricao.Text;
                objProdutoDTO.Preco = double.Parse(txtPreco.Text);
                objProdutoDTO.Quantidade = int.Parse(txtQuantidade.Text);
                objProdutoDTO.Peso = double.Parse(txtPeso.Text);
                objProdutoDTO.Tbl_categoria_id = Convert.ToInt32(cbxTbl_C.SelectedValue);
                objProdutoDTO.Tbl_fornecedor_id = Convert.ToInt32(cbxTbl_F.SelectedValue);

                objProdutoBLL.AlterarProduto(objProdutoDTO);
                MessageBox.Show("Os dados do PRODUTO cadastrado foram alterados com sucesso.");
                CarregarGridProduto();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione um produto para atualizar os dados.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
    }
}

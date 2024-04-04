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

namespace ProjetoProduto_3A07.UI
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtDescricao.Clear();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CarregarGridCategoria();
        }

        CategoriaBLL objCategoriaBLL = new CategoriaBLL();
        CategoriaDTO objCategoriaDTO = new CategoriaDTO();

        private void CarregarGridCategoria()
        {
            gridCategoria.DataSource = objCategoriaBLL.ListarCategorias();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //Agora sim, vamos atribuir os dados do formulário aos atributos da DTO

                objCategoriaDTO.Descricao = txtDescricao.Text;
                objCategoriaBLL.InserirCategoria(objCategoriaDTO);
                MessageBox.Show("Categoria Cadastrada");
                CarregarGridCategoria();
                Limpar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO.\n" + ex.Message);
            }
        }

        private void gridCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gridCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = gridCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                objCategoriaDTO.Id = int.Parse(txtId.Text);
                objCategoriaBLL.ExcluirCategoria(objCategoriaDTO);
                MessageBox.Show("A categoria foi Excluída");
                CarregarGridCategoria();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione uma categoria para excluir.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "") //Existe um ID selecionado?
            {
                objCategoriaDTO.Id = int.Parse(txtId.Text);
                objCategoriaDTO.Descricao = txtDescricao.Text;

                objCategoriaBLL.AlterarCategoria(objCategoriaDTO);
                MessageBox.Show("Os dados da CATEGORIA cadastrado foram alterados com sucesso.");
                CarregarGridCategoria();
                LimparComponentes();
            }
            else
            {
                MessageBox.Show("Selecione uma categoria para atualizar os dados.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
    }
}

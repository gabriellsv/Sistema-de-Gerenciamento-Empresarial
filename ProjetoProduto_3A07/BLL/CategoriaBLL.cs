using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    class CategoriaBLL
    {
        Conexao objDAL = new Conexao();
        private string tabela = "tbl_Categoria";

        public void InserirCategoria(CategoriaDTO objDTO)
        {
            string sql = $"INSERT INTO {tabela} VALUES(null, '{objDTO.Descricao}');";
            objDAL.ExecutarComando(sql);
        }

        public DataTable ListarCategorias()
        {
            return objDAL.ExecutarConsulta($"SELECT * FROM {tabela} ORDER BY id;");
        }

        public void AlterarCategoria(CategoriaDTO objDTO)
        {
            string sql = String.Format($@"UPDATE {tabela} SET descricao = '{objDTO.Descricao}'
                                                              WHERE id = '{objDTO.Id}';");
            objDAL.ExecutarConsulta(sql);
        }

        public void ExcluirCategoria(CategoriaDTO objDTO)
        {
            string sql = $"DELETE FROM {tabela} WHERE id = {objDTO.Id}";
            objDAL.ExecutarComando(sql);
        }

        public bool ValidarUsuario(string user, string password)
        {
            string query = String.Format($@"SELECT * FROM tbl_cliente WHERE email = '{user}' AND senha = '{password}';");

            DataTable resultado = new DataTable();

            resultado = objDAL.ExecutarConsulta(query);

            bool valor = resultado.Rows.Count == 1 ? true : false;    //uso do ternário para substituição do IF

            return valor;
        }

        public bool ValidarUsuario(string user)
        {
            string query = $"SELECT * FROM tbl_cliente WHERE email = '{user}';";

            DataTable resultado = new DataTable();

            resultado = objDAL.ExecutarConsulta(query);

            bool existe = resultado.Rows.Count == 1 ? true : false;    //uso do ternário para substituição do IF

            return existe;
        }

        public int Autenticar(string user, string password)
        {
            string query = String.Format($@"SELECT * FROM tbl_cliente WHERE email = '{user}' AND senha = '{password}';");

            DataTable resultado = new DataTable();

            resultado = objDAL.ExecutarConsulta(query);

            int tipoUsuario = (resultado.Rows.Count == 1) ? Convert.ToInt32(resultado.Rows[0]["tipoUsuario"]) : -1;

            return tipoUsuario;
        }
    }
}

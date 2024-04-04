using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    class FornecedorBLL
    {
        Conexao objConexao = new Conexao();
        string tabela = "tbl_Fornecedor";

        public void InserirFornecedor(FornecedorDTO objFornecedorDTO)
        {
            string sql = String.Format($@"INSERT INTO {tabela} VALUES(null, '{objFornecedorDTO.Nome}', 
                                                                            '{objFornecedorDTO.Email}', 
                                                                            '{objFornecedorDTO.Telefone}');");
            objConexao.ExecutarComando(sql);
        }

        public DataTable ListarFornecedores()
        {
            //DataTable query = new DataTable();
            //string sql = $"SELECT * FROM {tabela} ORDER BY nome;";
            //query = objConexao.ExecutarConsulta(sql);
               
            //return query;

            //ou apenas

            return objConexao.ExecutarConsulta($"SELECT * FROM {tabela} ORDER BY nome;");
        }

        public void AlterarFornecedor(FornecedorDTO objDTO)
        {
            string sql = String.Format($@"UPDATE {tabela} SET nome = '{objDTO.Nome}', 
                                                              email = '{objDTO.Email}',
                                                              telefone = '{objDTO.Telefone}'      
                                                          WHERE id = '{objDTO.Id}';");
            objConexao.ExecutarComando(sql);
        }

        public void ExcluirFornecedor(FornecedorDTO objDTO)
        {
            string sql = $"DELETE FROM {tabela} WHERE id = {objDTO.Id}";
            objConexao.ExecutarComando(sql);
        }

        public bool ValidarUsuario(string user, string password)
        {
            string query = String.Format($@"SELECT * FROM tbl_cliente WHERE email = '{user}' AND senha = '{password}';");

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            bool valor = resultado.Rows.Count == 1 ? true : false;    //uso do ternário para substituição do IF

            return valor;
        }

        public bool ValidarUsuario(string user)
        {
            string query = $"SELECT * FROM tbl_cliente WHERE email = '{user}';";

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            bool existe = resultado.Rows.Count == 1 ? true : false;    //uso do ternário para substituição do IF

            return existe;
        }

        public int Autenticar(string user, string password)
        {
            string query = String.Format($@"SELECT * FROM tbl_cliente WHERE email = '{user}' AND senha = '{password}';");

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            int tipoUsuario = (resultado.Rows.Count == 1) ? Convert.ToInt32(resultado.Rows[0]["tipoUsuario"]) : -1;

            return tipoUsuario;
        }
    }
}

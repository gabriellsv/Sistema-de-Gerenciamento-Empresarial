using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
using System.Windows.Forms;

namespace BLL
{
    class ClienteBLL
    {
        Conexao objDAL = new Conexao();
        string tabela = "tbl_Cliente";

        public void InserirCliente(ClienteDTO objClienteDTO)
        {
            string sql = String.Format($@"INSERT INTO {tabela} VALUES(null, '{objClienteDTO.Nome}', 
                                                                            '{objClienteDTO.Endereco}',
                                                                            '{objClienteDTO.Uf}',
                                                                            '{objClienteDTO.Telefone}',
                                                                            '{objClienteDTO.Email}',
                                                                            '{objClienteDTO.Senha}',
                                                                            '{objClienteDTO.Tbl_tipousuario_id}');");
            objDAL.ExecutarComando(sql);
        }

        public DataTable ListarClientes()
        {
            return objDAL.ExecutarConsulta($"SELECT * FROM {tabela} ORDER BY id;");
        }

        public DataTable ListarClientes(string sql)  //sql cibtém uma instrução SELECT
        {
            return objDAL.ExecutarConsulta(sql);
        }

        public DataTable ListarClientes (string campo, string valor)
        {
            return objDAL.ExecutarConsulta($"SELECT * FROM {tabela} WHERE {campo} like '%{valor}%' ORDER BY {campo};");
        }

        public void AlterarCliente(ClienteDTO objDTO)
        {
            string sql = String.Format($@"UPDATE {tabela} SET nome = '{objDTO.Nome}',
                                                              endereco = '{objDTO.Endereco}',
                                                              uf = '{objDTO.Uf}',
                                                              telefone = '{objDTO.Telefone}',
                                                              email = '{objDTO.Email}',
                                                              senha = '{objDTO.Senha}',
                                                              tbl_tipousuario_id = '{objDTO.Tbl_tipousuario_id}'
                                                              WHERE id = '{objDTO.Id}';");
            objDAL.ExecutarConsulta(sql);
        }

        public void ExcluirCliente(ClienteDTO objDTO)
        {
            string sql = $"DELETE FROM {tabela} WHERE id = {objDTO.Id}";
            objDAL.ExecutarComando(sql);
        }

        public bool ValidarUsuario(string user, string password)
        {
            string query = String.Format($@"SELECT * FROM {tabela} WHERE email = '{user}' AND senha = '{password}';");

            DataTable resultado = new DataTable();

            resultado = objDAL.ExecutarConsulta(query);

            bool valor = resultado.Rows.Count == 1 ? true : false;    //uso do ternário para substituição do IF

            return valor;
        }

        public bool ValidarUsuario(string user)
        {
            string query = $"SELECT * FROM {tabela} WHERE email = '{user}';";

            DataTable resultado = new DataTable();

            resultado = objDAL.ExecutarConsulta(query);

            bool existe = resultado.Rows.Count == 1 ? true : false;    //uso do ternário para substituição do IF

            return existe;
        }

        public int Autenticar (string user, string password)
        {
            string query = String.Format($@"SELECT * FROM {tabela} WHERE email = '{user}' AND senha = '{password}';");

            DataTable resultado = new DataTable();

            resultado = objDAL.ExecutarConsulta(query);

            int tipoUsuario = (resultado.Rows.Count == 1) ? Convert.ToInt32(resultado.Rows[0]["tblTipoUsuario"]) : -1;

            return tipoUsuario;
        }
    }
}

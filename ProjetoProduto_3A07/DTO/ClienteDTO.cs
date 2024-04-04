using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ClienteDTO
    {
        int id;
        private string nome;
        private string endereco;
        private string uf;
        private string telefone;
        private string email;
        private string senha;
        private int tbl_tipousuario_id;

        public int Id
        {
            set { this.id = value;  }
            get { return this.id;  }
        }

        public string Nome
        {
            set
            {
                if (value != String.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("Favor preencher o <<nome>>.");
                }
            }
            get
            {
                return this.nome;
            }
        }

        public string Endereco
        {
            set
            {
                if (value != String.Empty)
                {
                    this.endereco = value;
                }
                else
                {
                    throw new Exception("Preencha corretamente o endereço.");
                }
            }
            get
            {
                return this.endereco;
            }
        }

        public string Uf
        {
            set
            {
                if (value != "")
                {
                    this.uf = value;
                }
                else
                {
                    throw new Exception("Selecione a UF.");
                }
            }
            get
            {
                return this.uf;
            }
        }

        public string Telefone
        {
            set
            {
                if (value != String.Empty)
                {
                    this.telefone = value;
                }
                else
                {
                    throw new Exception("Preencha corretamente o telefone.");
                }
            }
            get
            {
                return this.telefone;
            }
        }

        public string Email
        {
            set
            {
                if (value != String.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Preencha o email.");
                }
            }
            get
            {
                return this.email;
            }
        }

        public string Senha
        {
            set
            {
                if (value != "")
                {
                    this.senha = value;
                }
                else
                {
                    throw new Exception("Preencha a senha");
                }
            }
            get
            {
                return this.senha;
            }
        }

        public int Tbl_tipousuario_id
        {
            set { this.tbl_tipousuario_id = value; }                                           
            get { return this.tbl_tipousuario_id; }
        }


    }
}

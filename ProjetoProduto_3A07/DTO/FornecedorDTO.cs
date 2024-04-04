using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class FornecedorDTO
    {
        int id;
        private string nome;
        private string email;
        private string telefone;

        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
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

        
    }
}

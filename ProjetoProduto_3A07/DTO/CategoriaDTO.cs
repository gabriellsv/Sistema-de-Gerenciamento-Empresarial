using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CategoriaDTO
    {
        private int id;
        private string descricao;

        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Descricao
        {
            set
            {
                if (value == "")
                {
                    throw new Exception("A descrição tem que ser preenchida.");
                }
                else
                {
                    this.descricao = value;
                }
            }
            get
            {
                return this.descricao;
            }
        }
    }
}
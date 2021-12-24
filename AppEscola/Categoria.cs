using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola
{
    class Categoria
    {
        public int IdCategoria { get; }
        public string nomeCategoria { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, string nomeCategoria)
        {
            this.IdCategoria = id;
            this.nomeCategoria = nomeCategoria;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola
{
    class Autor
    {
        public int IdAutor { get; }
        public string nomeAutor { get; set; }

        public Autor()
        {

        }

        public Autor(int id, string nomeAutor)
        {
            this.IdAutor = id;
            this.nomeAutor = nomeAutor;
        }
    }
}

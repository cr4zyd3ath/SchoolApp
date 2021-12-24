using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola
{
    class Editora
    {
        public int IdEditora { get; }
        public string nomeEditora { get; set; }
        public string Localidade { get; set; }

        public Editora()
        {

        }

        public Editora(int id, string nomeEditora, string localidade)
        {
            this.IdEditora = id;
            this.nomeEditora = nomeEditora;
            this.Localidade = localidade;
        }
    }
}

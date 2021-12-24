using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola
{
    class Livro
    {
        public int IdLivro { get; }
        public int isbn { get; set; }
        public string nomeLivro { get; set; }

        public string nomeAutor { get; set; }
        public int IdEditora { get; set; }
        public string Categoria { get; set; }
        public int anoEdicao { get; set; }

        public Livro()
        {

        }

        public Livro(int id, int isbn, string nomeLivro, string nomeAutor, string Categoria, int anoEdicao, int idEditora)
        {
            this.IdLivro = id;
            this.isbn = isbn;
            this.nomeLivro = nomeLivro;
            this.nomeAutor = nomeAutor;
            this.Categoria = Categoria;
            this.anoEdicao = anoEdicao;
            this.IdEditora = idEditora;
        }
    }
}

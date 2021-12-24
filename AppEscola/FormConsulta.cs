using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FormConsulta : Form
    {
        private OperacoesBD opBD;
        public FormConsulta()
        {
            InitializeComponent();
            opBD = new OperacoesBD();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            opBD.ListarLivros("SELECT * FROM Livros ORDER BY isbn");
            tabelaLivros.DataSource = opBD.dtTabelaLivros;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeEditora = txtnomeEditora.Text;
            opBD.ListarLivros("SELECT Livros.isbn, Editoras.Localidade FROM Livros INNER JOIN" +
                " Editoras ON Livros.IdEditora = Editoras.IdEditora WHERE Editoras.nomeEditora=" + nomeEditora);
            tabelaLivros.DataSource = opBD.dtTabelaLivros;
        }

    }
}

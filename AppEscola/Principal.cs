using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class Principal : Form
    {
        private OperacoesBD opBD;

        public Principal()
        {
            InitializeComponent();

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Editora> lista = new List<Editora>();
            opBD = new OperacoesBD();
            //this.tabControl1.SelectedTab = tabEditoras;
            lista = opBD.ListaEditora();
            tabelaEditora.DataSource = lista;

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            List<Editora> lista = new List<Editora>();
            opBD = new OperacoesBD();

            lista = opBD.ListaEditora();
            tabelaEditora.DataSource = lista;

            opBD.ListarLivros("SELECT Livros.IdLivro AS ID, Livros.isbn AS ISBN,  Livros.nomeLivro AS NomeﾠdoﾠLivro, Livros.nomeAutor AS NomeﾠdoﾠAutor,  Livros.Categoria AS Categoria,  Livros.anoEdicao AS AnoﾠdeﾠEdição,+" +
                "Editoras.nomeEditora AS Editora FROM Livros INNER JOIN Editoras ON Livros.IdEditora = Editoras.IdEditora");
            tabelaLivros.DataSource = opBD.dtTabelaLivros;

        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditora editora = new FormEditora();
            editora.StartPosition = FormStartPosition.CenterScreen;
            editora.ShowDialog();
            Principal_Load(sender, e);
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //List<Livro> Livros = new List<Livro>();
            //opBD = new OperacoesBD();
            //this.tabControl1.SelectedTab = tablivros;
            //livros = opBD.ListaLivros();
            //tabelaLivros.DataSource = livros;
            opBD.ListarLivros("SELECT Livros.IdLivro AS ID, Livros.isbn AS isbn, Livros.nomeLivro AS NomeﾠdoﾠLivro, Livros.nomeAutor AS NomeﾠdoﾠAutor, Livros.Categoria AS Categoria, Livros.anoEdicao AS AnoﾠdeﾠEdição,+" +
                "Editoras.nomeEditora AS Editora FROM Livros INNER JOIN Editoras ON Livros.IdEditora = Editoras.IdEditora");
            tabelaLivros.DataSource = opBD.dtTabelaLivros;
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLivro livro = new FormLivro();
            livro.StartPosition = FormStartPosition.CenterScreen;
            livro.ShowDialog();
            Principal_Load(sender, e);
        }

        private void ordemCrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta consulta = new FormConsulta();
            consulta.StartPosition = FormStartPosition.CenterScreen;
            consulta.ShowDialog();
            Principal_Load(sender, e);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelaEditora.SelectedRows.Count > 0)
            {
                int id = tabelaEditora.CurrentRow.Index;
                // Pega o ID da primeira coluna da linha selecionada e realiza a conversão para Integer
                int.TryParse(tabelaEditora.SelectedRows[0].Cells[0].Value.ToString(), out id);

                // Executa o formulario passando o Id do registro que será editado
                FormEditarEditora editar = new FormEditarEditora(id);
                editar.StartPosition = FormStartPosition.CenterScreen;
                editar.ShowDialog();
                Principal_Load(sender, e);
            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelaEditora.SelectedRows.Count > 0)
            {
                // Pega o ID da primeira coluna da linha selecionada e realiza a conversão para Integer
                int id = Convert.ToInt32(tabelaEditora.SelectedRows[0].Cells[0].Value.ToString());
                string nomeEditora = tabelaEditora.SelectedRows[0].Cells[1].Value.ToString();
                string Localidade = tabelaEditora.SelectedRows[0].Cells[2].Value.ToString();

                Editora editora = new Editora(id, nomeEditora, Localidade);
                DialogResult resultado = MessageBox.Show("Deseja mesmo remover este registo?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    opBD.EliminaEditora(editora);
                }
                Principal_Load(sender, e);
            }
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(tabelaLivros.SelectedRows[0].Cells[0].Value.ToString());
                int isbn = Convert.ToInt32(tabelaLivros.SelectedRows[0].Cells[1].Value.ToString());
                string nomeLivro = tabelaLivros.SelectedRows[0].Cells[2].Value.ToString();
                string nomeAutor = tabelaLivros.SelectedRows[0].Cells[3].Value.ToString();
                string Categoria = tabelaLivros.SelectedRows[0].Cells[4].Value.ToString();
                int anoEdicao = Convert.ToInt32(tabelaLivros.SelectedRows[0].Cells[5].Value.ToString());
                int idEditora = Convert.ToInt32(tabelaLivros.SelectedRows[0].Cells[6].Value.ToString());

                Livro livro = new Livro(id, isbn, nomeLivro, nomeAutor, Categoria, anoEdicao, idEditora);
                DialogResult resultado = MessageBox.Show("Deseja mesmo remover este registo?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    opBD.EliminaLivro(livro);
                }
                Principal_Load(sender, e);
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabLivros_Click(object sender, EventArgs e)
        {

        }

        private void tabelaLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            List<Autor> lista = new List<Autor>();
            opBD = new OperacoesBD();
            //this.tabControl1.SelectedTab = tabCategoria;
            lista = opBD.ListaAutor();
            tabelaAutores.DataSource = lista;
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAutor autor = new FormAutor();
            autor.StartPosition = FormStartPosition.CenterScreen;
            autor.ShowDialog();
            Principal_Load(sender, e);
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (tabelaAutores.SelectedRows.Count > 0)
            {
                // Pega o ID da primeira coluna da linha selecionada e realiza a conversão para Integer
                int id = Convert.ToInt32(tabelaAutores.SelectedRows[0].Cells[0].Value.ToString());
                string nomeAutor = tabelaAutores.SelectedRows[0].Cells[1].Value.ToString();

                Autor autor = new Autor(id, nomeAutor);
                DialogResult resultado = MessageBox.Show("Deseja mesmo remover este registo?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    opBD.EliminaAutor(autor);
                }
                Principal_Load(sender, e);
            }

        }

        private void inserirToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            FormCategoria categoria = new FormCategoria();
            categoria.StartPosition = FormStartPosition.CenterScreen;
            categoria.ShowDialog();
            Principal_Load(sender, e);

        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            List<Categoria> lista = new List<Categoria>();
            opBD = new OperacoesBD();
            //this.tabControl1.SelectedTab = tabCategoria;
            lista = opBD.ListaCategoria();
            tabelaCategorias.DataSource = lista;
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (tabelaEditora.SelectedRows.Count > 0)
            {
                int id = tabelaEditora.CurrentRow.Index;
                // Pega o ID da primeira coluna da linha selecionada e realiza a conversão para Integer
                int.TryParse(tabelaEditora.SelectedRows[0].Cells[0].Value.ToString(), out id);

                // Executa o formulario passando o Id do registro que será editado
                FormEditarEditora editar = new FormEditarEditora(id);
                editar.StartPosition = FormStartPosition.CenterScreen;
                editar.ShowDialog();
                Principal_Load(sender, e);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaEditora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (tabelaCategorias.SelectedRows.Count > 0)
            {
                // Pega o ID da primeira coluna da linha selecionada e realiza a conversão para Integer
                int id = Convert.ToInt32(tabelaCategorias.SelectedRows[0].Cells[0].Value.ToString());
                string nomeCategoria = tabelaCategorias.SelectedRows[0].Cells[1].Value.ToString();

                Categoria categoria = new Categoria(id, nomeCategoria);
                DialogResult resultado = MessageBox.Show("Deseja mesmo remover este registo?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    opBD.EliminaCategoria(categoria);
                }
                Principal_Load(sender, e);
            }
        }

        private void eliminarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (tabelaLivros.SelectedRows.Count > 0)
            {
                // Pega o ID da primeira coluna da linha selecionada e realiza a conversão para Integer
                int id = Convert.ToInt32(tabelaLivros.SelectedRows[0].Cells[0].Value.ToString());
                int isbn = Convert.ToInt32(tabelaLivros.SelectedRows[0].Cells[1].Value.ToString());
                string nomeLivro = tabelaLivros.SelectedRows[0].Cells[2].Value.ToString();
                string nomeAutor = tabelaLivros.SelectedRows[0].Cells[3].Value.ToString();
                string Categoria = tabelaLivros.SelectedRows[0].Cells[4].Value.ToString();
                int anoEdicao = Convert.ToInt32(tabelaLivros.SelectedRows[0].Cells[5].Value.ToString());
                int idEditora = Convert.ToInt32(tabelaLivros.SelectedRows[0].Cells[6].Value.ToString());

                Livro livro = new Livro(id, isbn, nomeLivro, nomeAutor, Categoria, anoEdicao, idEditora);
                DialogResult resultado = MessageBox.Show("Deseja mesmo remover este registo?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    opBD.EliminaLivro(livro);
                }
                Principal_Load(sender, e);
            }
        }
    }
}

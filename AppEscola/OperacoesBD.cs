using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    class OperacoesBD
    {
        private string strLigacao;
        private SqlConnection conn;
        public DataTable dtTabelaLivros;
        public DataTable dtTabelaEditora;
        public DataTable dtTabelaCategorias;
        public DataTable dtTabelaAutores;

        public OperacoesBD()
        {
            //@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=escola"
            strLigacao = @"Server=(LocalDB)\MSSQLLocalDB; Database=Biblioteca; Integrated Security=True";
        }



        public void InsereAutor(Autor novoAutor)
        {
            string querySQL = "INSERT INTO Autores (nomeAutor) VALUES (@nomeAutor)";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@nomeAutor", novoAutor.nomeAutor);
                cmd.Parameters.AddWithValue("@id", 0).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                //int id = Convert.ToInt32(cmd.Parameters["@id"].Value);
                MessageBox.Show("Autor inserido com sucesso na base de dados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Autor> ListaAutor()
        {
            string querySQL = "SELECT * FROM Autores";
            List<Autor> lista = new List<Autor>();
            try
            {
                //Cria uma instância de ligação à base de dados SQL Server Express
                conn = new SqlConnection(strLigacao);

                //Abre a ligação à base de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Autor(reader.GetInt32(0), reader.GetString(1)));
                }
            }
            catch (SqlException)
            {
                return lista;
            }
            finally
            {
                conn.Close();
            }

            return lista;
        }



        public List<Categoria> ListaCategoria()
        {
            string querySQL = "SELECT * FROM Categoria";
            List<Categoria> lista = new List<Categoria>();
            try
            {
                //Cria uma instância de ligação à base de dados SQL Server Express
                conn = new SqlConnection(strLigacao);

                //Abre a ligação à base de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Categoria(reader.GetInt32(0), reader.GetString(1)));
                }
            }
            catch (SqlException)
            {
                return lista;
            }
            finally
            {
                conn.Close();
            }

            return lista;
        }

        public void InsereCategoria(Categoria novaCategoria)
        {
            string querySQL = "INSERT INTO Categoria (nomeCategoria) VALUES (@nomeCategoria)";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@nomeCategoria", novaCategoria.nomeCategoria);
                cmd.Parameters.AddWithValue("@id", 0).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                //int id = Convert.ToInt32(cmd.Parameters["@id"].Value);
                MessageBox.Show("Categoria inserida com sucesso na base de dados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        public List<Editora> ListaEditora()
        {
            string querySQL = "SELECT * FROM Editoras";
            List<Editora> lista = new List<Editora>();
            try
            {
                //Cria uma instância de ligação à base de dados SQL Server Express
                conn = new SqlConnection(strLigacao);

                //Abre a ligação à base de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Editora(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
            }
            catch (SqlException)
            {
                return lista;
            }
            finally
            {
                conn.Close();
            }

            return lista;
        }

        public void EliminaAutor(Autor autor)
        {
            string querySQL = "DELETE FROM Autores WHERE IdAutor = @Id";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@Id", autor.IdAutor);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                    MessageBox.Show("Autor com id " + autor.IdAutor + " foi eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Autor com id " + autor.IdAutor + " não foi eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public void ListaCategoria(string querySQL)
        {
            try
            {
                //Cria uma instância de ligação à base de dados SQL Server Express
                conn = new SqlConnection(strLigacao);

                //Abre a ligação à base de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dtTabelaCategorias = new DataTable();
                adapter.Fill(dtTabelaCategorias);

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void ListaAutor(string querySQL)
        {
            try
            {
                //Cria uma instância de ligação à base de dados SQL Server Express
                conn = new SqlConnection(strLigacao);

                //Abre a ligação à base de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dtTabelaAutores = new DataTable();
                adapter.Fill(dtTabelaAutores);

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void ListaEditora(string querySQL)
        {
            try
            {
                //Cria uma instância de ligação à base de dados SQL Server Express
                conn = new SqlConnection(strLigacao);

                //Abre a ligação à base de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dtTabelaEditora = new DataTable();
                adapter.Fill(dtTabelaEditora);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsereEditora(Editora novaEditora)
        {
            string querySQL = "INSERT INTO Editoras (nomeEditora, Localidade) VALUES (@nomeEditora, @Localidade)";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@nomeEditora", novaEditora.nomeEditora);
                cmd.Parameters.AddWithValue("@Localidade", novaEditora.Localidade);
                cmd.Parameters.AddWithValue("@id", 0).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                //int id = Convert.ToInt32(cmd.Parameters["@id"].Value);
                MessageBox.Show("Editora inserida com sucesso na base de dados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void AtualizaEditora(Editora editora)
        {
            string querySQL = "UPDATE Editoras SET nomeEditora = @nomeEditora, Localidade = @Localidade WHERE IdEditora = @Id";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@nomeEditora", editora.nomeEditora);
                cmd.Parameters.AddWithValue("@Localidade", editora.Localidade);
                cmd.Parameters.AddWithValue("@Id", editora.IdEditora);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                    MessageBox.Show("Editora com id " + editora.IdEditora + " foi atualizada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Editora com id " + editora.IdEditora + " não foi atualizada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void EliminaEditora(Editora editora)
        {
            string querySQL = "DELETE FROM Editoras WHERE IdEditora = @Id";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@Id", editora.IdEditora);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                    MessageBox.Show("Editora com id " + editora.IdEditora + " foi eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Editora com id " + editora.IdEditora + " não foi eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void EliminaLivro(Livro livro)
        {
            string querySQL = "DELETE FROM Livros WHERE IdLivro = @Id";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@Id", livro.IdLivro);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                    MessageBox.Show("Livro com id " + livro.IdLivro + " foi eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Livro com id " + livro.IdLivro + " não foi eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void EliminaCategoria(Categoria categoria)
        {
            string querySQL = "DELETE FROM Categoria WHERE IdCategoria = @Id";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@Id", categoria.IdCategoria);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                    MessageBox.Show("Categoria com id " + categoria.IdCategoria + " foi eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Categoria com id " + categoria.IdCategoria + " não foi eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsereLivro(Livro novoLivro)
        {
            string querySQL = "INSERT INTO Livros (isbn, nomeLivro, nomeAutor, Categoria, anoEdicao, IdEditora) VALUES (@isbn, @nomeLivro, @nomeAutor, @Categoria, @anoEdicao, @IdEditora)";
            try
            {
                conn = new SqlConnection(strLigacao);
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                cmd.Parameters.AddWithValue("@isbn", novoLivro.isbn);
                cmd.Parameters.AddWithValue("@nomeLivro", novoLivro.nomeLivro);
                cmd.Parameters.AddWithValue("@nomeAutor", novoLivro.nomeAutor);
                cmd.Parameters.AddWithValue("@Categoria", novoLivro.Categoria);
                cmd.Parameters.AddWithValue("@anoEdicao", novoLivro.anoEdicao);
                cmd.Parameters.AddWithValue("@IdEditora", novoLivro.IdEditora);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro inserido com sucesso na base de dados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

               public List<Livro> ListaLivros()
        {
            string querySQL = "SELECT * FROM Livros";
            List<Livro> lista = new List<Livro>();
            try
            {
                //Cria uma instância de ligação à base de dados SQL Server Express
                conn = new SqlConnection(strLigacao);

                //Abre a ligação à base de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Livro(reader.GetInt32(0), reader.GetInt32(3), reader.GetString(1), reader.GetString(1), reader.GetString(1), reader.GetInt32(3),reader.GetInt32(3)));
                }
            }
            catch (SqlException)
            {
                return lista;
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public void ListarLivros(string querySQL)
        {
            try
            {
                //Cria uma instância de ligação à base de dados SQL Server Express
                conn = new SqlConnection(strLigacao);

                //Abre a ligação à base de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(querySQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dtTabelaLivros = new DataTable();
                adapter.Fill(dtTabelaLivros);

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

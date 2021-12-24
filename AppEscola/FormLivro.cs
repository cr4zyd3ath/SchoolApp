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
    public partial class FormLivro : Form
    {
        private OperacoesBD opBD;
        public FormLivro()
        {
            InitializeComponent();
            opBD = new OperacoesBD();
        }

        private void FormLivro_Load(object sender, EventArgs e)
        {
            cbEditora.DataSource = opBD.ListaEditora();
            cbEditora.ValueMember = "IdEditora";
            cbEditora.DisplayMember = "nomeEditora";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Livro novoLivro = new Livro();
            novoLivro.isbn = Convert.ToInt32(txtisbn.Text);
            novoLivro.nomeLivro = txtnomeLivro.Text;
            novoLivro.nomeAutor = txtnomeAutor.Text;
            novoLivro.Categoria = txtCategoria.Text;
            novoLivro.anoEdicao = Convert.ToInt32(txtanoEdicao.Text);
            novoLivro.IdEditora = (int)cbEditora.SelectedValue;

            opBD.InsereLivro(novoLivro);
            //Fechar o formulário
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtisbn.Clear();
            txtnomeLivro.Clear();
            txtnomeAutor.Clear();
            txtCategoria.Clear();
            txtanoEdicao.Clear();
            cbEditora.Text = "";
            txtisbn.Focus();
            txtanoEdicao.Focus();
        }
    }
}

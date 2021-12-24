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
    public partial class FormEditarEditora : Form
    {
        private int ID;
        private OperacoesBD opBD;
        public FormEditarEditora(int id)
        {
            this.ID = id;
            opBD = new OperacoesBD();
            InitializeComponent();
        }

        private void FormEditarEditora_Load(object sender, EventArgs e)
        {
            opBD.ListaEditora("SELECT * FROM Editoras WHERE IdEditora=" + this.ID);


            if (opBD.dtTabelaEditora != null && opBD.dtTabelaEditora.Rows.Count > 0)
            {
                DataRow linha = opBD.dtTabelaEditora.Rows[0];
                txtnomeEditora.Text = linha["nomeEditora"].ToString();
                txtLocalidade.Text = linha["Localidade"].ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nomeEditora = txtnomeEditora.Text;
            string Localidade = txtLocalidade.Text;
            Editora Editora = new Editora(this.ID, nomeEditora, Localidade);
            opBD.AtualizaEditora(Editora);
            this.Close();
        }
    }
}

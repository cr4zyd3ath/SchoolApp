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
    public partial class FormAutor : Form
    {
        private OperacoesBD opBD;
        public FormAutor()
        {
            InitializeComponent();
            opBD = new OperacoesBD();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Autor novoAutor = new Autor();
            novoAutor.nomeAutor = txtnomeAutor.Text;

            opBD.InsereAutor(novoAutor);
            //Fechar o formulário
            this.Close();
        }

        private void FormAutor_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnomeAutor.Clear();
        }

        private void FormAutor_Load_1(object sender, EventArgs e)
        {

        }
    }
}

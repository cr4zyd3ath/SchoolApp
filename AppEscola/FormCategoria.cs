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
    public partial class FormCategoria : Form
    {
        private OperacoesBD opBD;
        public FormCategoria()
        {
            InitializeComponent();
            opBD = new OperacoesBD();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Categoria novaCategoria = new Categoria();
            novaCategoria.nomeCategoria = txtnomeCategoria.Text;

            opBD.InsereCategoria(novaCategoria);
            //Fechar o formulário
            this.Close();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnomeCategoria.Clear();
        }
    }
}

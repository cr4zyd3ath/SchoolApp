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
    public partial class FormEditora : Form
    {
        private OperacoesBD opBD;
        public FormEditora()
        {
            InitializeComponent();
            opBD = new OperacoesBD();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Editora novaEditora = new Editora();
            novaEditora.nomeEditora = txtnomeEditora.Text;
            novaEditora.Localidade = txtLocalidade.Text;

            opBD.InsereEditora(novaEditora);
            //Fechar o formulário
            this.Close();
        }

        private void FormEditora_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnomeEditora.Clear();
            txtLocalidade.Clear();
        }
    }
}

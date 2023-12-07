using Agenda_Projeto_Leticia.Controller;
using Agenda_Projeto_Leticia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Projeto_Leticia.View
{
    public partial class TelaPesquisarCodigo : Form
    {
        public TelaPesquisarCodigo()
        {
            InitializeComponent();
        }

        private void btn_BuscarTelaPorCodigo_Click(object sender, EventArgs e)
        {
            Pessoa.Id = Convert.ToInt32(txb_BuscaPorCodigoTelaBuscarporcodigo.Text);
            ManipulaPessoa manipula = new ManipulaPessoa();
            manipula.BuscarCodigo();

            txb_nomeTelaBuscarporCodigo.Text = Pessoa.Nome;
            txb_emailTelaBuscarporCodigo.Text = Pessoa.Email;
            txb_foneTelaBuscarporCodigo.Text = Pessoa.Fone;

            // this.Visible = false;
        }

        private void btnSAAIRR_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

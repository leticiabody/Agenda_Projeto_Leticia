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
    public partial class TelaPesquisar : Form
    {
        public TelaPesquisar()
        {
            InitializeComponent();
        }

        private void btn_BuscarTelaPesquisar_Click(object sender, EventArgs e)
        {
            Pessoa.Id = Convert.ToInt32(txb_BuscaPorNome_TelaPesquisa.Text);
            ManipulaPessoa manipula = new ManipulaPessoa();
            manipula.BuscarCodigo();

            txb_nomeTelaPesquisar.Text = Pessoa.Nome;
            txb_email_Telapesquisar.Text = Pessoa.Email;
            txb_foneTelaPesquisar.Text = Pessoa.Fone;
            
        }
    }
}

using Agenda_Projeto_Leticia.Controller;
using Agenda_Projeto_Leticia.Model;
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

namespace Agenda_Projeto_Leticia.View
{
    public partial class TelaAlterar : Form
    {
        public TelaAlterar()
        {
            InitializeComponent();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            Pessoa.Id = Convert.ToInt32(txb_ID_Alterar.Text);
            Pessoa.Nome = txb_nomeTelaAlterar.Text;
            Pessoa.Email = txb_emailTelaAlterar.Text;
            Pessoa.Fone = txb_foneTelaAlterar.Text;

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
            manipulaPessoa.Atualizar();
        }

        private void btn_SairNovatela_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

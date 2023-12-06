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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btn_CadastrarTelaCadastro_Click(object sender, EventArgs e)
        {
            Pessoa.Nome = txb_nomeCadastro.Text;
            Pessoa.Fone = txb_celularCadastro.Text;
            Pessoa.Email = txb_emailCadastro.Text;

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
            manipulaPessoa.Cadastrar();
        }
    }
}

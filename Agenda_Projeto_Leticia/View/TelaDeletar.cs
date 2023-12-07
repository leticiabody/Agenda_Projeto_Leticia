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
    public partial class TelaDeletar : Form
    {
        public TelaDeletar()
        {
            InitializeComponent();
        }

        private void btn_buscar_TelaDeletar_Click(object sender, EventArgs e)
        {
            Pessoa.Id = Convert.ToInt32(txb_buscarId_TelaDeletar.Text);
            ManipulaPessoa manipula = new ManipulaPessoa();
            manipula.BuscarCodigo();

            txb_nomeTeladelar.Text = Pessoa.Nome;
            txb_fone_TelaDeletar.Text = Pessoa.Fone;
            txb_emailTelaDeletar.Text = Pessoa.Email;

        }

        private void btn_excluirTelaDeletar_Click(object sender, EventArgs e)
        {
            if (txb_buscarId_TelaDeletar.Text == "")
            {
                MessageBox.Show("Digite a Matricula do usuário");
            }
            else
            {
                var resposta = MessageBox.Show("Você está excluindo o contato. " + txb_nomeTeladelar.Text
                    + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Pessoa.Id = Convert.ToInt32(txb_buscarId_TelaDeletar.Text);

                    ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
                    manipulaPessoa.Apagar();
                    txb_nomeTeladelar.Text = "";
                    txb_emailTelaDeletar.Text = "";
                    txb_fone_TelaDeletar.Text = "";
                }
                else
                {
                    txb_nomeTeladelar.Text = "";
                    txb_emailTelaDeletar.Text = "";
                    txb_fone_TelaDeletar.Text = "";
                }
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

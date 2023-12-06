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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            TelaOpcaoCodigoouNome telaPesquisar = new TelaOpcaoCodigoouNome();
            telaPesquisar.Show();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            TelaAlterar telaAlterar = new TelaAlterar();
            telaAlterar.Show();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            TelaDeletar telaDeletar = new TelaDeletar();
            telaDeletar.Show();
        }
    }
}

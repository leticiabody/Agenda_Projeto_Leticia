using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Projeto_Leticia.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leticia.afernandes3\source\repos\Agenda_Projeto_Leticia\Agenda_Projeto_Leticia\BancoDeDados\AgendaFinal.mdf;Integrated Security=True";
        }
    }
}

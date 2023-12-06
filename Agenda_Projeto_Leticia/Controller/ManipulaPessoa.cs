using Agenda_Projeto_Leticia.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Projeto_Leticia.Controller
{
    internal class ManipulaPessoa
    {
        public void Cadastrar()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AdicionarPessoa",cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Pessoa.Nome);
                cmd.Parameters.AddWithValue("@fone", Pessoa.Fone);
                cmd.Parameters.AddWithValue("@email", Pessoa.Email);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo contato salvo com sucesso. ");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Apagar()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ApagarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", Pessoa.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Atualizar()
        {

        }
        public void BuscarCodigo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarCodigoPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", Pessoa.Id);
                cn.Open();
                var DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    Pessoa.Id = Convert.ToInt32(DR["Id"]);
                    Pessoa.Nome = DR["nome"].ToString();
                    Pessoa.Fone = DR["fone"].ToString();
                    Pessoa.Email = DR["email"].ToString();

                }
                else
                {
                    Pessoa.Id = 0;
                    Pessoa.Nome = "";
                    Pessoa.Fone = "";
                    Pessoa.Email = "";
                    MessageBox.Show("Busca não Executada...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BuscarNome()
            {

            }
    }
   
}
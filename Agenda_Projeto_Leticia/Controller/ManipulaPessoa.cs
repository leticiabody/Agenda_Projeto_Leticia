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
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AtualizarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", Pessoa.Id);
                cmd.Parameters.AddWithValue("@nome", Pessoa.Nome);
                cmd.Parameters.AddWithValue("@fone", Pessoa.Fone);
                cmd.Parameters.AddWithValue("@email", Pessoa.Email);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Alterado com sucesso");
            }
             catch(Exception)
            {
                throw;
            }
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
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Pessoa.Id = Convert.ToInt32(dr["Id"]);
                    Pessoa.Nome = dr["nome"].ToString();
                    Pessoa.Fone = dr["fone"].ToString();
                    Pessoa.Email = dr["email"].ToString();

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
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarnomePessoas", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Pessoa.Nome);
                cn.Open();
                var vr  = cmd.ExecuteReader();

                if (vr.Read())
                {
                    Pessoa.Id = Convert.ToInt32(vr["Id"]);
                    Pessoa.Nome = vr["nome"].ToString();
                    Pessoa.Fone = vr["fone"].ToString();
                    Pessoa.Email = vr["email"].ToString();
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

        }
    }
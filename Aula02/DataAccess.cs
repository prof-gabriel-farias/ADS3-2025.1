using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;

namespace Aula02
{
    public class DataAccess
    {
        private string connectionSTRING = "Server=localhost\\SQLEXPRESS;Database=SantaCruz;Uid=sa;Password=santacruz;Encrypt=No";
        public SqlConnection obterConexao()
        {
            SqlConnection conn = new SqlConnection(connectionSTRING);
            return conn;
        }
        public string CriarAluno(Pessoa person)
        {
            try
            {
                SqlConnection conn = obterConexao();
                conn.Open();
                string sqlcommand = @"INSERT INTO Pessoa (nome,sexo,idade,peso,ativo,matricula,altura)
                                      Values ('" + person.nome + "','" + person.sexo + "'," + person.idade +
                                        "," + person.peso + ",'" + person.ativo + "'," + person.matricula +
                                        "," + person.altura + ") ";

                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.ExecuteNonQuery();
                return "Aluno criado com sucesso.";
            }
            catch (Exception ex)
            {
                return "Falha ao criar aluno. - " + ex.Message;
            }
        }
        public DataTable CarregarAluno()
        {
            SqlConnection conn = obterConexao();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            string sqlcommand = "SELECT * FROM Pessoa";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcommand, conn);
            DataSet oDataSet = new DataSet();
            dataAdapter.Fill(oDataSet);
            DataTable oDataTable = new DataTable();
            oDataTable = oDataSet.Tables[0];
            return oDataTable;
        }
        public string ExcluirAluno(int matricula)
        {
            try
            {
                SqlConnection conn = obterConexao();
                conn.Open();

                string sqlcommand = @"DELETE FROM Pessoa WHERE matricula =" + matricula;

                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.ExecuteNonQuery();
                return "Aluno removido com sucesso.";
            }
            catch (Exception ex)
            {
                return "Falha ao remover aluno. - " + ex.Message;
            }
        }
        public string EditarAluno(Pessoa person, int matricula)
        {
            try
            {
                SqlConnection conn = obterConexao();
                conn.Open();

                string sqlcommand = @"UPDATE Pessoa SET nome = '" + person.nome + "'" +
                                    ",sexo = '" + person.sexo + "',idade =" + person.idade +
                                    ",ativo ='" + person.ativo + "' ,altura =" + person.altura +
                                    ",peso =" + person.peso + " WHERE matricula = " + matricula;

                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.ExecuteNonQuery();
                return "Aluno editado com sucesso.";
            }
            catch (Exception ex)
            {
                return "Falha ao editar aluno. - " + ex.Message;
            }
        }
    }
}

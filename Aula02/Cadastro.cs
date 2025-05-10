using Google.Protobuf.Compiler;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aula02
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            dvListaPessoas.DataSource = listaPessoas;
            txbPeso.Validated += TxbAlturaPeso_Validated;
            txbAltura.Validated += TxbAlturaPeso_Validated;
        }

        private void TxbAlturaPeso_Validated(object? sender, EventArgs e)
        {
            if (txbPeso.Text != string.Empty &&
                txbAltura.Text != string.Empty)
            {
                try
                {
                    double peso = double.Parse(txbPeso.Text);
                    double altura = double.Parse(txbAltura.Text);
                    if (peso > 0 && altura > 0)
                    {
                        txbIMC.Text = (calcularIMC(peso, altura)).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor Insira apenas números em peso e altura");
                }
            }
        }

        List<Pessoa> listaPessoas = new List<Pessoa>();


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool isOk = validarCampos();

            if (isOk)
            {
                Pessoa person = new Pessoa();

                person.nome = txbNome.Text;
                person.sexo = char.Parse(cbSexo.Text.Substring(0, 1));
                person.idade = Convert.ToInt32(txbIdade.Text);
                person.peso = double.Parse(txbPeso.Text);
                if (rbSim.Checked && rbNao.Checked == false)
                    person.ativo = true;
                else
                    person.ativo = false;
                person.altura = double.Parse(txbAltura.Text);

                string connectionSTRING = "Server=localhost\\SQLEXPRESS;Database=SantaCruz;Uid=sa;Password=santacruz;Encrypt=No";
                SqlConnection conn = new SqlConnection(connectionSTRING);
                conn.Open();

            
                string sqlcommand = @"INSERT INTO Pessoa (nome,sexo,idade,peso,ativo,matricula,altura)
                                      Values ('" + person.nome + "','" + person.sexo + "'," + person.idade +
                                      "," + person.peso + ",'" + person.ativo + "'," + person.matricula + 
                                      "," + person.altura + ") ";

                SqlCommand cmd = new SqlCommand(sqlcommand,conn);
                 cmd.ExecuteNonQuery();

                string msg = limparCampos();
                MessageBox.Show(msg);
                int contador = int.Parse(lblContador.Text) + 1;
                lblContador.Text = contador.ToString();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvListaPessoas.SelectedRows)
            {
                var matricula = row.Cells["matricula"].Value;

                string connectionSTRING = "Server=localhost\\SQLEXPRESS;Database=SantaCruz;Uid=sa;Password=santacruz;Encrypt=No";
                SqlConnection conn = new SqlConnection(connectionSTRING);
                conn.Open();

                string sqlcommand = @"DELETE FROM Pessoa WHERE matricula =" + matricula;

                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.ExecuteNonQuery();

                int contador = int.Parse(lblContador.Text) - 1;
                lblContador.Text = contador.ToString();
            }
        }
        public string limparCampos()
        {
            txbNome.Text = string.Empty;
            txbIdade.Text = string.Empty;
            txbPeso.Text = string.Empty;
            rbNao.Checked = false;
            rbSim.Checked = false;
            cbSexo.SelectedItem = null;
            return "Pessoa cadastrada com sucesso";
        }

        public bool validarCampos()
        {
            try
            {
                Convert.ToInt32(txbIdade.Text);
                char.Parse(cbSexo.Text.Substring(0, 1));
                double.Parse(txbPeso.Text);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro!");
                return false;
            }
        }

        public double calcularIMC(double peso, double altura)
        {
            double IMC = 0;
            IMC = (peso / (altura * altura));

            return IMC;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvListaPessoas.SelectedRows)
            {
                Pessoa varPessoa = new Pessoa();
                varPessoa = listaPessoas[row.Index];

                formEdicao f = new formEdicao(varPessoa);
                f.ShowDialog();


                listaPessoas[row.Index] = f.personReturn;
                dvListaPessoas.DataSource = listaPessoas.ToList();
            }
        }
        public void SQL()
        {
            //string connectionSTRING = "Server=localhost,Database=Alunos,Uid=root,Pwd=mysql";
            //MySqlConnection conn = new MySqlConnection(connectionSTRING);
            //conn.Open();
            //MySqlCommand cmd = new MySqlCommand();

            //System.Data. cmd = new SqlCommand();
            // string StrConnection = String.Format("Data Source={0};Initial Catalog={1};user id={2};Password={3}", Server, Database, Usuario, Senha);

            //using (SqlConnection conn = new SqlConnection(StrConnection))
            //{
            //    conn.Open();
            //    string sql = "INSERT INTO Alunos (Nome, Idade, altura) VALUES (@nome, @idade, @altura)";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.Parameters.AddWithValue("@nome", txbNome.Text);
            //    cmd.Parameters.AddWithValue("@idade", Convert.ToInt32(txbIdade.Text));
            //    cmd.Parameters.AddWithValue("@altura", txbAltura.Text);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Aluno cadastrado!");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionSTRING = "Server=localhost\\SQLEXPRESS;Database=SantaCruz;Uid=sa;Password=santacruz;Encrypt=No";
            SqlConnection conn = new SqlConnection(connectionSTRING);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            string sqlcommand = "SELECT * FROM Pessoa";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcommand, conn);
            DataSet oDataSet = new DataSet();
            dataAdapter.Fill(oDataSet);
            DataTable oDataTable = new DataTable();
            oDataTable = oDataSet.Tables[0];
            dvListaPessoas.DataSource = oDataTable;
        }
    }
}

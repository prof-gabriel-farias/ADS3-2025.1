using Google.Protobuf.Compiler;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aula02
{
    public partial class Cadastro : Form
    {
        DataAccess DAO = new DataAccess();
        public Cadastro()
        {
            InitializeComponent();

            txbPeso.Validated += TxbAlturaPeso_Validated;
            txbAltura.Validated += TxbAlturaPeso_Validated;

            dvListaPessoas.DataSource = DAO.CarregarAluno();
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
                /**** Endereço *///
                person.logradouro = endereco.Logradouro;
                person.numero = int.Parse(txbNumero.Text);
                person.bairro = endereco.Bairro;
                person.cidade = endereco.Localidade;
                person.UF = endereco.UF;
                person.cep = txbCEP.Text;

                MessageBox.Show(DAO.CriarAluno(person));

                string msg = limparCampos();
                dvListaPessoas.DataSource = DAO.CarregarAluno();

                int contador = int.Parse(lblContador.Text) + 1;
                lblContador.Text = contador.ToString();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvListaPessoas.SelectedRows)
            {
                var matricula = row.Cells["matricula"].Value;

                MessageBox.Show(DAO.ExcluirAluno(int.Parse(matricula.ToString())));

                int contador = int.Parse(lblContador.Text) - 1;
                lblContador.Text = contador.ToString();
                dvListaPessoas.DataSource = DAO.CarregarAluno();
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
                //varPessoa.altura = double.Parse(row.Cells["altura"].Value.ToString());
                varPessoa.idade = int.Parse(row.Cells["idade"].Value.ToString());
                varPessoa.ativo = bool.Parse(row.Cells["ativo"].Value.ToString());
                varPessoa.nome = row.Cells["nome"].Value.ToString();
                varPessoa.peso = double.Parse(row.Cells["peso"].Value.ToString());
                varPessoa.sexo = char.Parse(row.Cells["sexo"].Value.ToString());


                formEdicao f = new formEdicao(varPessoa);
                f.ShowDialog();

                varPessoa = f.personReturn;
                var matricula = row.Cells["matricula"].Value;

                MessageBox.Show(DAO.EditarAluno(varPessoa, int.Parse(matricula.ToString())));
                dvListaPessoas.DataSource = DAO.CarregarAluno();
            }
        }

        Endereco endereco = new Endereco();
        public async Task<Endereco> carregarcep(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    endereco = JsonConvert.DeserializeObject<Endereco>(responseBody);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o CEP: " + ex.Message);
                }
                return endereco;
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
            endereco = await carregarcep(txbCEP.Text);
            txbEndereco.Text = endereco.Logradouro + " N." + txbNumero.Text + "- " + endereco.Bairro + "- " + endereco.Localidade + "/" + endereco.UF;
        }
        public void lerArquivo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de Texto|*.txt;*.csv";
            ofd.Title = "Selecione um arquivo para importar";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] linhas = File.ReadAllLines(ofd.FileName);

                    foreach (string linha in linhas)
                    {
                        string[] campos = linha.Split(','); 
                        Pessoa person = new Pessoa();
                        person.nome = campos[0];
                        person.sexo = char.Parse(campos[1]);
                        person.idade = int.Parse(campos[2]);
                        person.peso = double.Parse(campos[3]);
                        person.ativo = bool.Parse(campos[4]);
                        DAO.CriarAluno(person);
                    }
                    dvListaPessoas.DataSource = DAO.CarregarAluno();
                    MessageBox.Show(linhas.Count().ToString() + " Alunos criados através do upload de arquivo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
                }
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            lerArquivo();
        }
    }
}

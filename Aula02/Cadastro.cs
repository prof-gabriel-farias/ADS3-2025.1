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
        }
        List<Pessoa> listaPessoas = new List<Pessoa>();

        public class Pessoa
        {
            public string nome { get; set; }
            public char sexo { get; set; }
            public int idade { get; set; }
            public double peso { get; set; }
            public bool ativo { get; set; }
            public int matricula { get { return gerarmatricula(); } }

            private int gerarmatricula()
            {
                Random rd = new Random();
                int m = rd.Next(5000);
                return m;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
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

            listaPessoas.Add(person);
            dvListaPessoas.DataSource = listaPessoas.ToList();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvListaPessoas.SelectedRows)
            {
                listaPessoas.RemoveAt(row.Index);
                dvListaPessoas.DataSource = listaPessoas.ToList();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvListaPessoas.SelectedRows)
            {
                Pessoa varPessoa = new Pessoa();
                varPessoa = listaPessoas[row.Index];
                varPessoa.nome = "ALTEREI O NOME";

                listaPessoas[row.Index] = varPessoa;
                dvListaPessoas.DataSource = listaPessoas.ToList();
            }
        }
    }
}

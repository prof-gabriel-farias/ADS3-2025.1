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

                listaPessoas.Add(person);
                dvListaPessoas.DataSource = listaPessoas.ToList();
                string msg = limparCampos();
                MessageBox.Show(msg);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvListaPessoas.SelectedRows)
            {
                listaPessoas.RemoveAt(row.Index);
                dvListaPessoas.DataSource = listaPessoas.ToList();
            }
        }
        public string limparCampos()
        {
            txbNome.Text = string.Empty;
            txbIdade.Text = string.Empty;
            txbPeso.Text = string.Empty;
            rbNao.Checked = false;
            rbSim.Checked = false;
            cbSexo.SelectedItem = null ;
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
                MessageBox.Show(ex.Message,"Ocorreu um Erro!");
                return false;
            }
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
    }
}

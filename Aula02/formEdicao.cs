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
    public partial class formEdicao : Form
    {
        public Pessoa personReturn { get; set; }
        public formEdicao(Pessoa pessoa)
        {
            InitializeComponent();
            txbNome.Text = pessoa.nome;
            txbIdade.Text = pessoa.idade.ToString();
            txbPeso.Text = pessoa.peso.ToString();
            if (pessoa.ativo == true)
                rbSim.Checked = true;
            else
                rbNao.Checked = true;

            switch (pessoa.sexo)
            {
                case 'M':
                    cbSexo.SelectedIndex = 0;
                    break;
                case 'F':
                    cbSexo.SelectedIndex = 1;
                    break;
                case 'N':
                    cbSexo.SelectedIndex = 2;
                    break;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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

            this.personReturn = person;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

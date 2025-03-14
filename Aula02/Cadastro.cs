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
        }

        public string nome { get; set; }
        public char sexo { get; set; }
        public int idade { get; set; }
        public double peso { get; set; }
        public bool ativo { get; set; }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                txbNome.Text + "\n" +
                cbSexo.Text + "\n" +
                txbIdade.Text + "\n" +
                txbPeso.Text + "\n" +
                rbSim.Checked.ToString() + "\n" +
                rbNao.Checked.ToString()
                );
        }
    }
}

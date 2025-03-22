using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
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
}

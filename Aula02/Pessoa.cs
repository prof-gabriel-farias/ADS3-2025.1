﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        public int matricula { get { return Gerarmatricula(); } }
        public double altura { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string UF { get; set; }

        private int Gerarmatricula()
        {
            Random rd = new Random();
            int m = rd.Next(5000);
                return m;
                     
        }
    }
}

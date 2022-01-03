using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoDeHerança
{
    internal class Professor : Pessoa // a classe Professor esta recebendo propriedades da classe Pessoa
    {
        public double Salario { get; set; }
    }
}

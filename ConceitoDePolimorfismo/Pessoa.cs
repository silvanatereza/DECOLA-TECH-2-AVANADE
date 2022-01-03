using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoDePolimorfismo
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

   

        public virtual void Apresentar() // colocamos a palavra virtual para informa que ela pode ser sobrescrito//
        {
            Console.WriteLine($" Olá ! meu nome é {Nome } é minha idade é {Idade} anos ");
        }
    }
}

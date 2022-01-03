using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoDeClassesAbstratas
{
    public abstract class Conta // colocamos a palavra abstract para mostra que a classe é abstrata não estânciar//
    {
        protected double Saldo; // usando o protected somente a própria classes e as classes filhas podem acessar//

        public  abstract   void Creditar( double valor );
        // como é um método abstrato não temos implementação //


        public void ExibirSaldo()// método não abstrato//
        {
            Console.WriteLine($"seu saldo é {Saldo}");

        }
        
        
        
        
        
    }
}

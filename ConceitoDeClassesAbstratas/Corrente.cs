using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoDeClassesAbstratas
{
    internal class Corrente : Conta
    {
        public override void Creditar( double valor )
        {
            base.Saldo = valor; // a palavra base signifa que o atributo pertence a classe pai 
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoDePolimorfismo
{
    internal class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar() // colocamos a palavra override significa sobreescrita//
        {
            Console.WriteLine($" Olá ! meu nome é {Nome } sou aluno   e tenho  {Idade} anos ");
           /*  podemos colocar o que quiser pois quando for se chamado o método Apresentar vai ser o 
            *  do aluno */
           
        }
    }
}

using ConceitoDePolimorfismo;
using System;

/*  POLIMORFISMO 
Com o polimorfismo, podemos sobrescrever métodos das classes filhas para que 
se comportem de maneira diferente e ter sua pr´pria implementação 
namespace ConceitoDePolimorfismo */

    internal class Program
    {
        static void Main(string[]args)
        {
            Aluno p1 = new Aluno();


            p1.Nome = " roberta ";
            p1.Idade = 33;
            p1.Nota = 10;
            p1.Apresentar();

          Professor p2 = new Professor();
            p2.Nome = " jose ";
            p2.Idade = 45;
            p2.Salario = 23.890;
            p2.Apresentar();



        
            
        }
    }

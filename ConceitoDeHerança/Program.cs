using ConceitoDeHerança;
using System;

/*          HERANÇA 

A herança nos permite reutilizar atributos , métodos e comportamentos 
de uma classe em outras classes.
Serve para agupar objetos que são do mesmo tipo , porém com características diferentes 


Temos a classe Pessoa e criando 2 classes alunos e professor para exemplificar */

 
namespace BootcampAvanadePOO
{
    public class Program 
    {
        static void Main(string[] args)
        {

           

            Aluno p1 = new Aluno();

      
            p1.Nome = "silvana ";
            p1.Idade = 33;

           

            p1.Apresentar(); ;

        }
    }

}
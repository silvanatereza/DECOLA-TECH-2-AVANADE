using System;

/*  CLASSE ABSTRATA 
 Uma classe abstrata tem como objetivo ser exclusivamente um modelo
para ser herdado , portanto não pode ser instanciada.
Você pode implementar métodos ou deixa-los a cargo de quem herdar.*/

namespace ConceitoDeClassesAbstratas
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Corrente c = new Corrente();
            c.Creditar(100);

            c.ExibirSaldo();
        }
    }
}
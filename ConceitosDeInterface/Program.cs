using System;

          // INTERFACE 
/* É como se fosse uma classe abstrata , podendo definir métodos abstratos
para serem implementadas.

Assim como uma classe abstrata , uma interface não pode ser instanciada 


exemplificando : foi criada uma interface com seus métodos definidos e a classe 
calculadora esta implementando a interface */

namespace ConceitosDeInterface
{
    public class Program 
    {
     static void Main(string[] args)
        {
            ICalculadora cal = new Calculadora();

            Console.WriteLine(cal.Somar(10,40));
        }

    }
}

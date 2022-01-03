using System;
/* ENCAPSULAMENTO : serve para ptoteger uma classe e definir limites 
para alterações de suas propriedades.
Serve para ocultar seu comportamento e expor somente o necessário */

namespace ConceitoEncapsulameto
{
    public class Program 
    {
        static void Main(string[] args)
        {
            // criando o objeto 
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30); // chamamos método publico e damos os valores as parametros //

            Console.WriteLine($" Área {r.ObterArea()}");

        }

    }
}

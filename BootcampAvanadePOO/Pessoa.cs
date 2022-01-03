using System;


namespace BootcampAvanadePOO
{
    internal class Pessoa
    {
        // ATRIBUTOS DA CLASSE 
        public string Nome { get; set; }
        public int Idade { get; set; }

        // MÉTODOS DA CLASSE 

        public void Apresentar()
        {
            Console.WriteLine($" Olá ! meu nome é {Nome } é minha idade é {Idade} anos ");
        }
    }
}

/* Usando o conceito de Abstração estou criando uma classe do tipo pessoa e abstraindo as informações 
 * necessária para pode criar o projeto */
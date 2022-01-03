using System;



namespace ConceitoEncapsulameto
{
    internal class Retangulo 
    {

        //  propriedades privadas //
        private double Comprimento;
        private double largura;

        /* essas propriedades so poderam ser manupuladas através do método DefinirMedidas 
         * que esta recebendo 2 parametros */
        

        public void DefinirMedidas(double Comprimento, double largura)
        {
            this.Comprimento = Comprimento;
            this.largura = largura;
        }
        public double ObterArea()
        {
            return Comprimento * largura;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosDeInterface
{
    internal class Calculadora : ICalculadora
    {
        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Somar (int n1, int n2)
        {
            return n1 + n2; 
        }
        public int Somar (int n1, int n2 , int n3)
        {
            return n1 + n2 + n3;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}

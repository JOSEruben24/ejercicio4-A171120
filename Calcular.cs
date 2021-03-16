using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWS
{
    public class Calcular
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }

        public decimal cuadrado (decimal n1 , decimal n2)
        {
            return n1 * n2;
        }

        public decimal triangulo(decimal n1, decimal n2)
        {
            return (n1 * n2)/2;

        }

        public float circulo(float n1, float n2)
        {
            
           return n1*(n2*n2);           
        }
    }
}
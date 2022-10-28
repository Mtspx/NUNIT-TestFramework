using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.models
{
    public class Operacoes
    {
        public float Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public float Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public float Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public float Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
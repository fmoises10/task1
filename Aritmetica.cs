﻿namespace TestProject1
{
    internal class Aritmetica
    {
        public int sumar(int a, int b)
        {
            return a + b;
        }

        public int restar(int a, int b)
        {
            return a - b;
        }

        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public double dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
            return (double)a / b;
        }
    }
}

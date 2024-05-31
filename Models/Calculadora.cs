using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_NET.Interfaces;

namespace POO_NET.Models
{
    // implementando Interface
    public class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        // // métodos com corpo, ou seja, já implementados na interface, não precisam ser implementados aqui. 
        // public int Dividir(int num1, int num2)
        // {
        //     return num1 / num2;
        // }
    }
}
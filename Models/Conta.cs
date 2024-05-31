using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_NET.Models
{    
    // classe abstrata para ser usada como modelo
    public abstract class Conta
    {    
        // protected: protegido contra alterações externas, com exceção das classes filhas.
        protected decimal Saldo;

        public abstract void Creditar(decimal valor); // método abstrato, quem herdar terá que implementa-lo

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu salário é: {Saldo}");
        }
    }
}
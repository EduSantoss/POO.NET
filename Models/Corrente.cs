using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_NET.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor) // lembrando, override = sobrescrever, polimorfismo.
        {   // atributo Saldo pode ser alterado só de quem herda, já que seu nível de proteção é protected.
            Saldo += valor; 
        }
    }
}
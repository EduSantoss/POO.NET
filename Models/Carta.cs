using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_NET.Models
{    
    // enum vem de enumeração, usado para declarar um conjunto de constantes nomeadas
    // basicamente criando um "tipo" 
    // classe enum vinda do desafio de código !!!
    public enum Naipe { Paus = 0, Ouros = 1, Copas = 2, Espadas = 3 }
    public enum Valor { As = 1, Valete = 2, Dama = 3, Rei = 4 }
    public class Carta
    {
        private Naipe naipe;
        private Valor valor;

        public Carta(Naipe n, Valor v)
        {
            naipe = n;
            valor = v;
        }

        public Naipe GetNaipe()
        {
            return naipe;
        }

        public Valor GetValor()
        {
            return valor;
        }
    }
}
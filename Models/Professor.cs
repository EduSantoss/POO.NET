using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_NET.Models
{    // sealed para identificar classe selada, que não pode ter classes filhas.
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
          
        // construtor criado aqui também, que recebe o de Pessoa.
        public Professor(string nome) : base(nome) // base chama o construtor da classe pai
        {
            
        }

        public decimal Salario { get; set; }

        // método selado, não pode ser modificado.
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}.");
        }
    }
}
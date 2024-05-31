using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_NET.Models
{
    // herança feita
    public class Aluno : Pessoa
    {
        public Aluno()
        {

        }

        // construtor criado aqui também, que recebe o de Pessoa.
        public Aluno(string nome) : base(nome) // base chama o construtor da classe pai
        {

        }


        // exclusiva de aluno
        public double Nota { get; set; }

        public override void Apresentar()
        {   // sobrescrevendo método Apresentar
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade}, e sou um aluno nota {Nota}.");
        }
    }
}
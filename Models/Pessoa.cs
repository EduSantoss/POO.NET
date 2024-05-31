using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_NET.Models
{
    public class Pessoa
    {   // ctor para criar construtor.

        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        // tornando privado evita que seja herdado
        public virtual void Apresentar()
        { // virtual significa que o método pode ser sobrescrito, se assim for desejado.
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}
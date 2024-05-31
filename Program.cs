using POO_NET.Interfaces;
using POO_NET.Models;

// // Objeto do tipo pessoa criado, concretização da abstração do mundo real
// Pessoa p1 = new Pessoa();

// p1.Nome = "Eduardo";
// p1.Idade = 20;

// p1.Apresentar();

// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();

// // c1.Saldo; não pode ser acessado devido a seu nível de proteção

// // instanciando Aluno que herda de Pessoa
// Aluno a1 = new Aluno("Eduardo");
// // a1.Nome = "Eduardo";
// a1.Idade = 23;
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor("Leonardo Buta");
// // p1.Nome = "Leonardo Buta";
// p1.Idade = 30;
// p1.Salario = 1500;
// p1.Apresentar();

// // instanciando classe Corrente que herda da classe abstrata Conta
// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

// Computador pc = new Computador();
// pc.ToString();


// // interface, nao se pode instanciar a interface ICalcularado, mas a partir dela podemos instanciar a classe contrato

// ICalculadora calc = new Calculadora();
// Console.WriteLine(calc.Multiplicar(3, 9));


// desafio cartas !!!

// input para escolher a carta desejada pela pessoa
int valorEscolhido, naipeEscolhido;
do
{
    Console.WriteLine("Digite um valor de 1 a 4.");
    valorEscolhido = int.Parse(Console.ReadLine());
} while (valorEscolhido < 1 || valorEscolhido > 4);

// repete o laço até ser um valor que esteja fora do estabelecido para repetição, quer um valor entre 1 e 4, mas se digitar um valor como 0 ou 5, o laço irá repetir !!!!
do
{   
    Console.WriteLine("Digite um valor de 0 a 3."); 
    naipeEscolhido = int.Parse(Console.ReadLine());
} while (naipeEscolhido < 0 || naipeEscolhido > 3);

// criação da carta escolhida pelo usuário
Carta cartaEscolhida = new Carta((Naipe)naipeEscolhido, (Valor)valorEscolhido);

// Exibição da carta escolhida pelo usuário
string nomeValor = "", nomeNaipe = "";

switch (cartaEscolhida.GetValor())
{
    case Valor.As:
        nomeValor = "Ás";
        break;
    case Valor.Valete:
        nomeValor = "Valete";
        break;
    case Valor.Dama:
        nomeValor = "Dama";
        break;
    case Valor.Rei:
        nomeValor = "Rei";
        break;
}

switch (cartaEscolhida.GetNaipe())
{
    case Naipe.Paus:
        nomeNaipe = "Paus";
        break;
    case Naipe.Ouros:
        nomeNaipe = "Ouros";
        break;
    case Naipe.Copas:
        nomeNaipe = "Copas";
        break;
    case Naipe.Espadas:
        nomeNaipe = "Espadas";
        break;
}
Console.WriteLine($"A carta escolhida foi: {nomeValor} de {nomeNaipe}");

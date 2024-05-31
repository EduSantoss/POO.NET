<h1>DIO | Resumo .NET e C# - Modulo 2</h1>

-> Manipulando dados e objetos _NET
[Digital Innovation One](https://www.dio.me/en).

## 📚 Documentação 
- [Documentação .NET](https://git-scm.com/doc)
- [Documentação C#](https://docs.github.com/pt)

## 💻 Resumos das Aulas

| Aulas | Resumos |
|-------|---------|
| Resumo sobre .NET | [Resumos]() |

### Programação Orientada a Objetos

-> A POO é um paradigma de programação, ou seja, corresponde a uma técnica de programação para um fim específico.

-> Uma maneira de se programar.

-> 4 pilares: Abstração, Encapsulamento, Herança e Polimorfismo.

### Classes e Objetos

-> Classes são basicamente representações de objetos da vida real, um molde para construir objetos. Possui propriedades e metodos que definem o que esse molde faz.

-> Objeto é a classe concretizada, criado com as características fornecidas pela classe.

### Outros paradigmas de programação

-> Modelo de técnicas, estruturas e formas de solucionar um problema.

-> Paradigma é diferente de linguagem de programação.

-> Linguagens implementam um ou mais paradigmas.

-> Tipos: POO, estruturada, imperativa, procedural, orientada a eventos, lógica.

### 1 Pilar -> Abstração

-> Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.

### 2 Pilar -> Encapsulamento

-> Serve para proteger uma classe e definir limites para alterações de suas prorpriedades.

-> Serve para ocultar seu comportamento e expor somente o necessário.

-> Em um diagrama de código, o - ao lado da propriedade ou metodo significa que eles não podem ser alterados ou acessados, já o +, significa que eles podem ser modificados.

-> Exemplo(vide código): ContaCorrente, criado objeto e a propriedade Saldo é privada, ou seja, não pode ser alterado, digamos que tenha uma regra que o Saldo não pode ser negativo, tentar tirar 1500 quando só se tem 1000. Ai entra o encapsulamento. Disponibiliza um metodo Sacar e nele são feitas as validações necessárias.

### 3 Pilar -> Herança

-> Permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.

-> Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes.

-> Vide código, classe Pessoa, classes Aluno e Professor herdando dessa classe, e com mudanças especificas.

-> Herança precisa fazer sentido!!! Não dá para uma classe carro herdar de Pessoa, ainda que ela tenha características como Nome ou até Idade do veiculo, parecidas.

-> Classe filho herda da classe pai, e as filhos podem se tornar pais e ter uma cascata de herança, apesar disso ser possível, é recomendado analisar melhor o código se não uma modificação nas classes pai pode gerar um quebra generalizada.

-> Uma classe só pode herdar de uma classe, no C# não é possível esse comportamento.

-> Também podemos definir um construtor padrão na classe Pai para ser herdado nas classes filhas.

-> Exemplo: Na classe pessoa (vide código) quero que ao menos o nome seja obrigatório.

->>> Cuidado ao fazer isso, pode quebrar um código já existente, exemplo classe Pessoa depois de ter um construtor gerou uma quebra nas que herdam dela, classe Aluno e Professor.


### 4 Pilar -> Polimorfismo

-> Palavra grega que significa "muitas formas".

-> Com ele podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e tenham sua própria implementação.

-> Formas diferentes de se implementar um método para as classes que herdam uma classe pai.

-> Exemplo: apresentações diferentes para a classe Aluno e Professor, em relação a classe pai Pessoa.

-> Polimorfismo em tempo de compilação (Overload/Early Binding): basicamente dois métodos com nomes iguais mas com parametros diferentes, e que não depende de herança. 

Exemplo:
```
public class Calculadora
{
   public int Somar(int num1, int num2)
   {
      return num1 + num2;
   }

    public int Somar(int num1, int num2, int num3)
   {
      return num1 + num2 + num3;
   }
}
```

-> Polimorfismo em tempo de execução (Override/Late Binding): aquele que foi aplicado as classes Aluno e professor, modifica o método da classe pai, e obviamente, depedende de herança. 

### Classe Abstrata

-> Tem o objetivo de ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada.

-> Você pode implementar métodos ou deixá-los a cargo de quem herdar, também permite implementar métodos abstratos (com nível de proteção protected), obrigando a classe que herdou a fazer polimorfismo. 

-> Exemplo(ver código): uma classe abstrata Conta, para abranger classes, classe pai, (conta) corrente, (conta) poupança, (conta) especial. Mas contas compartilham algo em comum, como Saldo e ExibirSaldo.


### Classe Selada

-> Uma classe que tem como objetivo de impedir que outras classe façam uma herança dela, ou seja, nenhuma classe pode ser sua derivada/filha.

-> Também existem métodos e propriedades seladas, que não podem ser sobrescritos pelas classes filhas.

-> Palavra Sealed para identificar.

### Classe Object

-> A classe System.Object é a mãe de todas as classes na hierarquia do .NET .

-> Todas as classes derivam, direta ou indiretamente, da classe Object, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas.

-> Busca prover serviços de baixo nível para suas classes filhas, como métodos de referências, comparação, finalização e representação de objetos.

| Métodos da Classe Object | O que fazem |
|--------------------------|-------------|
| Equals(Object) | Determina se o objeto especificado é igual ao objeto atual.|
| Equals(Object, Object) | Determina se as instâncias de objeto especificadas são consideradas iguais.|
| Finalize() | Permite que um objeto tente liberar recursos e executar outras operações de limpeza antes de ser recuperado pela coleta de lixo.|
| GetHashCode() | Serve como a função de hash padrão. |
| GetType() | Obtém o Type da instância atual. | 
| MemberwiseClone() | Cria uma cópia superficial do Object atual. |
| ReferenceEquals(Object, Object) | Determina se as instâncias de Object especificadas são a mesma instância. |
| ToString() | Retorna uma cadeia de caracteres que representa o objeto atual. |

### Interface

-> Um contrato que pode ser implementado por uma classe, bastante parecida com uma classe abstrata.

-> Pode definir métodos abstratos para serem implementados.

->>> No caso em que a interface já implementa o método abstrato, a classe que tiver o contrato não precisa implementa-lo (ver código classe Calculadora)!!!.

-> Não pode ser instanciada.

-> Quando tratamos de interface não falamos em herança, mas sim em implementar o que foi passado.

->>> Uma classe pode implementar mais de uma interface!!!.

-> Exemplo: Interface ICalculadora, com os métodos soma, subtrair, multiplicar e dividir. Só possui os métodos, que através desse "contrato", precisam ser implementados pelas classes CalculadoraComum e CalculadoraCientifica.

#### Enumerações 

-> Direto dos desafios de códigos, achei interessante trazer sobre Enumerações.

-> Enumerações ou enum (palavra chave no código), são usadas para declarar um conjunto de constantes nomeadas.

Exemplo:
```
public enum Naipe { Paus = 0, Ouros = 1, Copas = 2, Espadas = 3 }
```
ou ainda: 
```
public enum DiasDaSemana
{
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}
```

-> Trás vantagens como legibilidade para o código, pois substituiem números com nomes significativos;

-> Manutenibilidade ao facilitar a manutenção, já que alterações nos nomes da constantes são propagadas automaticamente pelo código.

-> Segurança de tipo: reduzem as chances de erros que podem ocorrer ao usar constantes literais.

-> valores subjacentes: por padrão, os valores dos membros de uma enum começam em zero e aumentam em um em um para cada membro. Esses valores podem ser alterados.

```
public enum DiasDaSemana
{
    Domingo = 0,
    Segunda = 1,
    Terca = 2,
    Quarta = 3,
    Quinta = 4,
    Sexta = 5,
    Sabado = 6
}
```
Assim como o tipo padrão que é Int pode ser alterado:
```
public enum ByteEnum : byte
{
    Zero,
    Um,
    Dois
}
```



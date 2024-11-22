using System;

  class Program {
  public static void Main(string[] args) {
  int pessoas = 0, somaIdadesMulheres = 0, somaMulheres = 0, somaHomens = 0, somaIdadesHomens = 0, idade;
  string nome, sexo;
    while (pessoas < 10) {
    Console.WriteLine("Digite o nome da pessoa: ");
    nome = Console.ReadLine();
    Console.Write("Informe a idade da pessoa: ");
    idade = int.Parse(Console.ReadLine());
    Console.Write("Informe o sexo da pessoa (feminino ou masculino): ");
    sexo = Console.ReadLine();
    if(sexo == "feminino") {
      somaMulheres++;
      somaIdadesMulheres = somaIdadesMulheres + idade;
    } if(sexo == "masculino") {
      somaHomens++;
      somaIdadesHomens = somaIdadesHomens + idade;
    }
    pessoas = pessoas + 1;
    }

  Console.WriteLine("A soma de idades das mulheres é " + somaIdadesMulheres);
  Console.WriteLine("A soma de idades dos homens é " + somaIdadesHomens);
  }
}
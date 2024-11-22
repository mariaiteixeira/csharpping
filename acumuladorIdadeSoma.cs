using System;

  class Program {
  public static void Main(string[] args) {
  int pessoas = 0, somaIdades = 0, idade;
  string nome;
    while (pessoas < 10) {
    Console.WriteLine("Digite o nome da pessoa: ");
    nome = Console.ReadLine();
    Console.Write("Informe a idade da pessoa: ");
    idade = int.Parse(Console.ReadLine());
    somaIdades = somaIdades + idade;
    pessoas = pessoas + 1;
    }

  Console.WriteLine("A soma de idades deu " + somaIdades);
  }
}
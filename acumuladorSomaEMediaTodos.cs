using System;

  class Program {
  public static void Main(string[] args) {
  int pessoas = 0, idade, somaIdades = 0;
  double media;
  string nome;
    while (pessoas < 10) {
    Console.WriteLine("Digite o nome da pessoa: ");
    nome = Console.ReadLine();
    Console.Write("Informe a idade da pessoa: ");
    idade = int.Parse(Console.ReadLine());
    somaIdades = somaIdades + idade;
    pessoas = pessoas + 1;
    }
    media = (somaIdades/10);
    Console.WriteLine("A soma das idades é "+somaIdades);
    Console.WriteLine("A média das idades é "+media);

  }
}
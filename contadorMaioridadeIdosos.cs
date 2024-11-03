using System;

class Program {
  public static void Main(string[] args) {
  int x = 1, qtMaioridade = 0, qtIdosos = 0;
  int num;
  string nome;
  while (x <= 10) {
    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Digite a sua idade: ");
    num = int.Parse(Console.ReadLine());
    if(num >= 18)
    qtMaioridade = qtMaioridade + 1;
    if(num >= 65 && num <= 75)
    qtIdosos = qtIdosos + 1;
    x = x + 1;
    }
  Console.WriteLine("Número de pessoas com maioridade: " + qtMaioridade);
  Console.WriteLine("Número de pessoas entre 65 a 75 anos: " + qtIdosos);
  }
}
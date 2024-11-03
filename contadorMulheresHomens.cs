using System;

class Program {
  public static void Main(string[] args) {
    
  int x = 1, numeroMulheres = 0, numeroHomens = 0;
  string nome, sexo;
    
  while (x <= 10) {
    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Digite seu sexo: ");
    sexo = Console.ReadLine();
    if(sexo == "feminino") {
      numeroMulheres++;
    } else if(sexo == "masculino") {
      numeroHomens++;
    } else {
      Console.WriteLine("Sexo inválido");
    }
    x++;
  }
    
  Console.WriteLine("Número de mulheres: " + numeroMulheres);
  Console.WriteLine("Número de homens: " + numeroHomens);
  }
}
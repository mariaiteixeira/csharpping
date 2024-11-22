using System;

class Program {
    public static void Main(string[] args) {
  
  int x = 1;
  int imc, abaixoImc = 0, noImcIdeal = 0, maiorPesoImc = 0;
  double peso, altura;
  string nome;
  
  while (x <= 6) {
    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o seu peso: ");
    peso = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a sua altura: ");
    altura = double.Parse(Console.ReadLine());
    
    imc = (int)(peso / (altura * altura));

    Console.WriteLine("Seu IMC é: " + imc);
    if(imc < 20) {
      x++;
      abaixoImc++;
      Console.WriteLine(nome + ", você está abaixo do peso");
    } else if(imc >= 20 && imc <= 25) {
      x++;
      noImcIdeal++;
      Console.WriteLine(nome + ", você está no peso ideal");
    } if(imc > 25) {
      x++;
      maiorPesoImc++;
      Console.WriteLine(nome + " está com o peso maior que o ideal para o IMC");
    }
    }
    x++;
      
    Console.WriteLine("O número de pessoas abaixo do peso é: " + abaixoImc);
    Console.WriteLine("O número de pessoas no peso ideal é: " + noImcIdeal);
    Console.WriteLine("O número de pessoas com o peso maior que o ideal é: " + maiorPesoImc);
  }

}
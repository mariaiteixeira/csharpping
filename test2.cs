//variavel = Console.ReadLine(); -> aqui recebe um valor do usuário

/* Ler inteiros: int.Parse(Console.ReadLine());
ou Convert.ToInt32(Console.ReadLine());

Ler valores reais: Double.Parse(Console.ReadLine());
float.Parse(Console.ReadLine());
Convert.ToDouble(Console.ReadLine());

Ler booleanos: bool.Parse(Console.ReadLine());

Textos normais é só o Console.Readline(); mesmo */

using System;

class Program {
    public static void Main (string[] args)
    {
        int n1, n2, soma;
        double media;
        Console.Write("Digite um número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        n2 = int.Parse(Console.ReadLine());
        soma = n1 + n2;
        media = soma / 2;
        Console.WriteLine("Soma = "+soma);
        Console.WriteLine("Media = "+media);
    }
}
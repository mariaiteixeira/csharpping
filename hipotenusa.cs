using System;

class Program {
    public static void Main (string[] args) 
    {   Double hipotenusa, cateto1, cateto2;

        Console.Write("Digite o primeiro cateto: ");
        cateto1 = Double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo cateto: ");
        cateto2 = Double.Parse(Console.ReadLine());

        hipotenusa = Math.Sqrt(Math.Pow(cateto1,2) + Math.Pow(cateto2,2));

        Console.WriteLine($"A hipotenusa é igual a {hipotenusa}");

    }
}
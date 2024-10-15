using System;

class Program {
    public static void Main (string[] args) 
    {
        double salario, inss;

        Console.Write("Digite o seu salário: ");
        salario = Double.Parse(Console.ReadLine());

        inss = 0.11 * salario;

        Console.WriteLine($"Você irá pagar R${inss} de INSS.");

    }
}
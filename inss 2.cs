using System;

class MainClass 
{
    public static void Main (string[] args) 
    {
        double Salario, INSS;
        Console.Write("Digite o salário do funcionário: R$ ");
        Salario = Double.Parse(Console.ReadLine());
        if (Salario <= 1000)
            INSS = Salario * 0.08;
        else
            INSS = Salario * 0.10;
        Console.WriteLine($"Valor a ser descontado do INSS = R$ {INSS:0.00}");
    }
}
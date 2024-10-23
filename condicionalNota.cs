using System;

class Program
{
    public static void Main(string[] args)
    {
        int nota;
        Console.Write("Digite a nota do aluno: ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 60)
        {
        Console.WriteLine("O aluno foi aprovado.");
        Console.WriteLine("Parabéns!");
        }

        else
        {
        Console.WriteLine("O aluno foi reprovado.");
        Console.WriteLine("É necessário estudar mais.");
        }

    }
}
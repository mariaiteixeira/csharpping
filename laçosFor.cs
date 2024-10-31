/* Exercício: faça um programa que imprima seu nome 15 vezes iniciando a variável auxiliar a partir
de 1. */

using System;

class Program{
    public static void Main (string[] args) {
        for(int aux = 1; aux <= 15; aux++)
            Console.WriteLine("Maria")
    }
}

/* Exercício: altere o programa que imprima seu nome 15 vezes iniciando a variável auxiliar a partir
de 117 */

using System;

class Program{
    public static void Main (string[] args) {
        for(int aux = 117; aux <= 132; aux++)
            Console.WriteLine("Maria");
    }
}

/* Exercício: faça um programa que imprima os números de 1 até 100. */

using System;

class Program {
    public static void Main(string[] args) {
        for(int i = 1; i <= 100; i++)
        Console.WriteLine(i);
    }
}

/* Exercício: faça um programa que calcule a área das circunferências com raio variando entre 1 e
15. */

using System;

class Program {
    public static void Main(string[] args) {
        // Declaração das variáveis
        double areaUm;
        double areaDois;
        for(int raio = 1; raio <= 15; raio++) {
        areaUm = Math.Pow(raio, 2);
        areaDois = Math.PI * areaUm;
        Console.Write($"Área da circunferência = {areaDois}\n\n");
        }
    }
}

/* Exercício: faça um programa que calcule a área das circunferências com raio variando entre x e
y, sendo x e y informados pelo usuário. */

using System;

class Program {
    public static void Main(string[] args) {
        // Declaração das variáveis
        double areaUm, areaDois, vi, vf, u;
        Console.WriteLine("Digite o valor do raio inicial: ");
        vi = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do raio final: ");
        vf = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o incremento, ou seja, passo: ");
        u = double.Parse(Console.ReadLine());
        for(double raio = vi; raio <= vf; raio = raio + u) {
        areaUm = Math.Pow(raio, 2);
        areaDois = Math.PI * areaUm;
        Console.Write($"Área da circunferência = {areaDois}\n\n");
        }
    }
}
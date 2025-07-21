using System; // Importa o namespace System, que contém Console, etc.

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Resolvendo Exercicio 1 ---");
        Exercicio1();
        Console.WriteLine("\n--- Resolvendo Exercicio 2 ---");
        Exercicio2();
        Console.WriteLine("\n--- Resolvendo Exercicio 3 ---");
        Exercicio3();
    }

    public static void Exercicio1()
    {
        int a = 10;
        int b = 20;
        double c = (double)(a + b) / 2;
        c = c - 40;

        int[] v = new int[4]; // Array com 4 posições (índices 0 a 3)
        v[3] = a + b + (int)c; // Converta c para int se o array for int

        Console.WriteLine($"A: {a}");
        Console.WriteLine($"B: {b}");
        Console.WriteLine($"C: {c}");
        Console.WriteLine($"V[3]: {v[3]}");
    }

    public static void Exercicio2()
    {
        int a = 2;
        int[] v = new int[8]; // Array de tamanho suficiente para índices até 7

        Console.Write("A: ");
        while (a < 8)
        {
            v[a] = 10 * a;
            Console.Write($"{a}, ");
            a = a + 1;
        }
        Console.WriteLine(); // Nova linha após a sequência de 'a'

        Console.WriteLine("Valores de V preenchidos:");
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] != 0) // Imprime apenas os valores que foram explicitamente definidos pelo loop
            {
                Console.WriteLine($"V[{i}]: {v[i]}");
            }
        }
    }

    public static void Exercicio3()
    {
        int a = 7;
        int b = a - 6; // b será 1

        int[] v = new int[6]; // Array de tamanho suficiente para índices até 5

        Console.WriteLine($"A: {a}");
        Console.WriteLine($"B inicial: {b}");

        while (b < a)
        {
            v[b] = b + a;
            Console.WriteLine($"V[{b}]: {v[b]}"); // Mostra o valor de v[b] a cada iteração
            b = b + 2;
        }

        Console.WriteLine("\nValores finais do Array V (preenchidos):");
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] != 0) // Imprime apenas os elementos que foram alterados
            {
                Console.WriteLine($"V[{i}]: {v[i]}");
            }
        }
    }
}
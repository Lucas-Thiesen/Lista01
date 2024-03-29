using System.Runtime.Intrinsics.X86;

namespace EX23.ConsoleApp
{
    internal class Program
    {
        //Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            int fibo1 = 0, fibo2 = 1;

            Console.Write(fibo1 + " " + fibo2 + " ");

            while (fibo2 < numero1)
            {
                int fibo3 = fibo1 + fibo2;
                Console.Write(fibo3 + " ");
                fibo1 = fibo2;
                fibo2 = fibo3;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

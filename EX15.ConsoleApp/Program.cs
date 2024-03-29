using System.Runtime.Intrinsics.Arm;

namespace EX15.ConsoleApp
{
    internal class Program
    {
        //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

        static void Main(string[] args)
        {
            #region INPUT
            Console.WriteLine("Insira três valores!");
            Console.WriteLine("Valor 1");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor 2");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor 3");
            int valor3 = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO E OUTPUT
            if (valor1 > valor2 && valor2 > valor3)
                Console.WriteLine("{0} {1} {2}", valor1, valor2, valor3);

            else if (valor1 > valor2 && valor1 > valor3 && valor3 > valor2)
                Console.WriteLine("{0} {1} {2}", valor1, valor3, valor2);

            else if (valor2 > valor1 && valor1 > valor3)
                Console.WriteLine("{0} {1} {2}", valor2, valor1, valor3);

            else if (valor2 > valor1 && valor2 > valor3 && valor3 > valor1)
                Console.WriteLine("{0} {1} {2}", valor2, valor3, valor1);

            else if (valor3 > valor2 && valor2 > valor1)
                Console.WriteLine("{0} {1} {2}", valor3, valor2, valor1);

            else if (valor3 > valor2 && valor1 > valor2)
                Console.WriteLine("{0} {1} {2}", valor3, valor1, valor2);

            Console.ReadKey();
            #endregion
        }
    }
}

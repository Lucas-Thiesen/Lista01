namespace EX19.ConsoleApp
{
    internal class Program
    {
        //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

        static void Main(string[] args)
        {
            for (int numeroImpar = 101; numeroImpar <= 199; numeroImpar += 2)
            {
                Console.WriteLine(numeroImpar);
            }
            Console.ReadKey();
        }
    }
}

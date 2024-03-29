namespace EX21.ConsoleApp
{
    internal class Program
    {
        //Escrever um algoritmo que leia um valor para uma variável
        //N de 1 a 10 e calcule a tabuada de N. Mostre a tabuada na forma: 

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * n;
                Console.WriteLine("{0} x {1} = {2}", i, n, resultado);
            }
            Console.ReadKey();
        }
    }
}

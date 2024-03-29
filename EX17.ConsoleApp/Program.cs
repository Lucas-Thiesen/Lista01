namespace EX17.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

        static void Main(string[] args)
        {
            #region INPUT
            Console.WriteLine("Digite um número!: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region PROCESSO E OUTPUT
            if (numero % 2 == 0) Console.WriteLine("O número é par");
            else Console.WriteLine("O número é impar");

            Console.ReadKey();
            #endregion
        }
    }
}

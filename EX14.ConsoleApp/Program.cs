namespace EX14.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

        static void Main(string[] args)
        {
            #region INPUT
            Console.WriteLine("Digite o Valor de A: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o Valor de B: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o Valor de C: ");
            decimal c = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO E OUTPUT
            if (a + b < c) 
            {
                Console.WriteLine("a soma de a + b é menor que c: ");
            }
            else
            {
                Console.WriteLine("a soma de a + b é maior que c: ");
            }
            Console.ReadLine();
            #endregion
        }
    }
}

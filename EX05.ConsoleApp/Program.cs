namespace EX05.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma esfera

        static void Main(string[] args)
        {
            #region INPUT
            Console.Clear();
            Console.WriteLine("Digite o RAIO da esfera: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
            #endregion

            #region OUTPUT
            Console.WriteLine("O volume da esfera é de: " + volume);
            Console.ReadLine();
            #endregion
        }
    }
}

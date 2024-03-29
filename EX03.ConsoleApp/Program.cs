namespace EX03.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o volume de um Cilindro

        static void Main(string[] args)
        {
            #region INPUT
            double raio, altura, volume;
            Console.Clear();
            Console.WriteLine("Digite o RAIO do cilindro: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a ALTURA do cilindro: ");
            altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            #endregion

            #region OUTPUT
            Console.WriteLine("O volume do cilindro é de: " + volume);
            Console.ReadLine();
            #endregion
        }
    }
}

using System;

namespace EX06ConsoleApp
{
    internal class Program
    {
        //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

        static void Main(string[] args)
        {
            #region INPUT
            Console.Clear();
            Console.WriteLine("Digite a temperatura da sua cidade em CELCIUS: ");
            double tempCelcius = Convert.ToDouble(Console.ReadLine());
            #endregion
            #region PROCESSAMENTO
            double tempFahrenheit = (tempCelcius * 9 / 5) + 32;
            #endregion
            #region OUTPUT
            Console.WriteLine("A temperatura em FAHRENHEIT é de: " + tempFahrenheit);
            Console.ReadLine();
            #endregion
        }
    }
}

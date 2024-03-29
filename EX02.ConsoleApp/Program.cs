using System.Text.RegularExpressions;
using System;

namespace EX02.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

        static void Main(string[] args)
        {
            #region INPUT
            decimal temperaturaFahrenheit, temperaturaCelcius;
            Console.Clear();
            Console.WriteLine("Digite a temperatura na sua cidade (Fahrenheit): ");
            temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            temperaturaCelcius = (temperaturaFahrenheit - 32) * 5 / 9;
            #endregion

            #region OUTPUT
            Console.WriteLine("A temperatura em Celcius é de: " + temperaturaCelcius);
            Console.ReadLine();
            #endregion
        }
    }
}

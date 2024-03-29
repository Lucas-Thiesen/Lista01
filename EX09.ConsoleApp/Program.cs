using System.Xml;

namespace EX09.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

        static void Main(string[] args)
        {
            #region INPUT
            Console.Clear();
            Console.WriteLine("Informe a nota da primeira prova: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da primeira prova: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota da primeira prova: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da primeira prova: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
            #endregion

            #region OUTPUT
            Console.WriteLine("A media ponderada das provas é de: " + mediaPonderada);
            Console.ReadLine();
            #endregion
        }
    }
}

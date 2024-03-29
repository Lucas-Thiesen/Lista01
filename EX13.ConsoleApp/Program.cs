using System.Runtime.ConstrainedExecution;

namespace EX13.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
        //Após o aumento, desconte 8% de impostos.Imprima o salário inicial, o salário com o aumento e o salário final.

        static void Main(string[] args)
        {
            #region INPUT
            Console.Clear();
            Console.WriteLine("Informe o salário do funcionário: ");
            decimal salarioAtual = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            decimal salarioAumento = (salarioAtual * 0.15m) + salarioAtual;
            decimal salarioImposto = (salarioAumento * 8 / 100) - salarioAumento;
            #endregion

            #region OUTPUT
            Console.WriteLine("O salário inicial era de: " + "R$"+salarioAtual);
            Console.WriteLine("O salário com aumento ficou em: " + "R$"+salarioAumento);
            Console.WriteLine("Descontado o imposto ficou em: " + "R$" + salarioImposto);
            Console.ReadLine();
            #endregion
        }
    }
}

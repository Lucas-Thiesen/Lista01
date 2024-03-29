using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace EX12.ConsoleApp
{
    internal class Program
    {
        //Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
        //Considere sempre anos completos, e que um ano possui 365 dias.
        //Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
        static void Main(string[] args)
        {
            #region INPUT
            Console.Clear();
            Console.WriteLine("Bem vindo ao programa dias vididos! ");
            Console.WriteLine("Digite o seu nome: ");
            string nome = (Console.ReadLine());

            Console.WriteLine("Digite quantos anos você tem! ");
            double idade = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            double idadeDias = idade * 365;
            #endregion

            #region OUTPUT
            Console.WriteLine(nome + " Você já viveu: " + idadeDias + " dias!");
            Console.ReadLine();
            #endregion
        }
    }
}

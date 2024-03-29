using static System.Reflection.Metadata.BlobBuilder;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace EX11.ConsoleApp
{
    internal class Program
    {
        //A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.
        //Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia,
        //o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos),
        //e quanto deve guardar numa conta de poupança (10% do total arrecadado).
        //Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos,
        //faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular os dados solicitados.

        static void Main(string[] args)
        {
            #region INPUT
            Console.Clear();
            const decimal PrecoDoPao = 0.12m;
            const decimal PrecoDaBroa = 1.50m;
           
            Console.WriteLine("Quantas Broas foram vendidas HOJE?: ");
            decimal broas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Quantos paes foram vendidos HOJE?: ");
            decimal paes = Convert.ToDecimal(Console.ReadLine());
            #endregion
            #region PROCESSAMENTO
            decimal totalBroa = broas * PrecoDaBroa;
            decimal totalPaes = paes * PrecoDoPao;

            decimal valorTotal = totalBroa + totalPaes;
            decimal poupanca = valorTotal * 0.1m;
            #endregion
            #region OUTPUT
            Console.WriteLine("O total vendido HOJE foi: " + valorTotal);
            Console.WriteLine("O valor que será destinado a poupança é de: " + poupanca);

            Console.ReadKey();
            #endregion
        }
    }
}

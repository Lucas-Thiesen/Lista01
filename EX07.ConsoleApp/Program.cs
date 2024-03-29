namespace EX07.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o salário total de um vendedor.
        //Deverá ser informado o salário base e o total de vendas.
        //A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            #region INPUT
            Console.Clear();
            Console.WriteLine("Informe o salário BASE do vendedor: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o TOTAL DE VENDAS do vendedor: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a comissão do vendedor (PORCENTAGEM): ");
            double comissao = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            double salarioTotal = (comissao / 100) * totalVendas + salarioBase;
            #endregion

            #region OUTPUT
            Console.WriteLine("O salário do vendedor é de: " + salarioTotal);
            Console.ReadLine();
            #endregion
        }
    }
}

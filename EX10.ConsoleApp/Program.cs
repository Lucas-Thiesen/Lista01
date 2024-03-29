namespace EX10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        //A imobiliária Imóbilis vende apenas terrenos retangulares.
        //Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
        {
            #region INPUT
            Console.Clear();
            Console.WriteLine("Informe o Comprimento do terreno em mts: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura do terreno em mts: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region PROCECESSAMENTO
            double dimensao = largura * comprimento;
            #endregion

            #region OUTPUT
            Console.WriteLine("a dimensão do terreno é de: " + dimensao+"²");
            Console.ReadLine();
            #endregion
        }
    }
}

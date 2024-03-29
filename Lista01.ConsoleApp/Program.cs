namespace Lista01.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma caixa retangular


        static void Main(string[] args)
        {
            decimal comprimento, largura, altura, volume;
            #region ENTRADA DE DADOS
            Console.Clear();
            Console.WriteLine("Informe o COMPRIMENTO da caixa: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a LARGURA da caixa: ");
            largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a ALTURA da caixa: ");
            altura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region PROCESSANDO
            volume = comprimento * altura * largura;
            #endregion

            #region SAIDA DE DADOS
            Console.WriteLine("O volume da caixa é de: " + volume);
            Console.ReadLine();
            #endregion
        }
    }
}

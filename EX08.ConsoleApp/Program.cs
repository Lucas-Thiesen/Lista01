namespace EX08.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular a média harmônica das notas de um Aluno

        static void Main(string[] args)
        {
            #region INPUT
            Console.Clear();
            Console.WriteLine("Digite as 4 notas do aluno no semestre! ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());
            decimal nota3 = Convert.ToDecimal(Console.ReadLine());
            decimal nota4 = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            decimal mediaHarmonica = 4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4));
            #endregion

            #region OUTPUT
            Console.WriteLine("A media das notas é de: " + mediaHarmonica);
            Console.ReadLine();
            #endregion
        }
    }
}

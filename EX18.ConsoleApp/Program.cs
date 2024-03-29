namespace EX18.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois
        //, caso contrário multiplique A por B.
        //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.
        static void Main(string[] args)
        {
            #region INPUT
            int c;
            Console.WriteLine("Digite o primeiro número! ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número! ");
            int b = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO E OUTPUT
            if (a == b) { c = a + b; }
            else { c = a * b; }

            Console.WriteLine("o valor de C é: " + c);
            Console.ReadKey();
            #endregion
        }
    }
}

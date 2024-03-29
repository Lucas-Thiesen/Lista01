namespace EX04.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o consumo de combustível por Km.
        //Deverá ser informado a quilometragem Inicial e Final do Percurso do Veículo.
        //Deverá ser informado o Consumo de Combustível
        static void Main(string[] args)
        {
            #region INPUT
            double kmInicial, kmFinal, consumoVeículo;
            Console.Clear();
            Console.WriteLine("Informe a kilometragem inicial: ");
            kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a kilometragem final: ");
            kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o consumo do seu veículo: ");
            consumoVeículo = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            double kmRodados = kmFinal - kmInicial;
            double consumoKm = kmRodados / consumoVeículo;
            #endregion

            #region OUTPUT
            Console.WriteLine("O consumo por KM na viagem foi de: " + consumoKm);
            Console.ReadLine();
            #endregion
        }
    }
}

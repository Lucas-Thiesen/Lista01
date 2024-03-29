﻿using System;
using System.Runtime.Intrinsics.X86;

namespace EX16.ConsoleApp
{
    internal class Program
    {
        //O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde
        //para dar uma indicação sobre a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura) ².
        //Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
        //IMC em adultos Condição
        //Abaixo de 18,5
        //Abaixo do peso
        //Entre 18,5 e 25 Peso normal
        //Entre 25 e 30
        //Acima do peso
        //Acima de 30 obeso

        static void Main(string[] args)
        {
            #region INPUT   
            Console.WriteLine("Informe o seu peso: ");
            decimal peso = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe a sua altura");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region PROCESSAMENTO
            decimal imc = peso / (altura * altura);
            #endregion

            #region OUTPUT
            if (imc < 18.5m) Console.WriteLine("Abaixo do peso");
            else if (imc < 25) Console.WriteLine("Peso normal");
            else if (imc < 30) Console.WriteLine("Acima do peso");
            else Console.WriteLine("Obeso");
            
            Console.ReadKey();
            #endregion
        }
    }
}

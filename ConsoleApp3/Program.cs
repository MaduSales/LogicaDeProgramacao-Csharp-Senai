using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Olá, vamos calcular o seu IMC: ");

            Console.WriteLine("Digite a sua altura (em metros, exemplo -> 1,50): ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu peso (em kg, exemplo -> 50,0): ");
            peso = double.Parse(Console.ReadLine());


            imc = peso / (altura * altura);


            if (imc < 16.9)
            {
                Console.WriteLine("Muito abaixo do peso.");
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("IMC normal.");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Você está acima do peso.");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade grau I.");
            }
            else if (imc >= 35 && imc <= 40)
            {
                Console.WriteLine("Obesidade grau II.");
            }
            else
            {
                Console.WriteLine("Obesidade grau III.");
            }
            Console.WriteLine("O seu IMC é " + Math.Round(imc,2));
        }
    }
}

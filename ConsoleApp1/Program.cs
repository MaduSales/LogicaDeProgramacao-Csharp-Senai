using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoAtual, anoNascimento, idade;

            Console.WriteLine("Digite o ano atual");
            anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu ano de nascimento");
            anoNascimento = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNascimento;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }

            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Digite qualquer tecla para continuar");
            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nivel, hora, aula, salarioSemanal = 0, salarioMensal;
            string nome;

            Console.WriteLine("Qual o nome do seu professor?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o nível do seu professor? 1, 2 ou 3? ");
            nivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas aulas ele dá por semana? ");
            aula = int.Parse(Console.ReadLine());

            if (nivel == 1)
            {
                salarioSemanal = aula * 12;
            }
            else if (nivel == 2)
            {
                salarioSemanal = aula * 17;
            }
            else if (nivel == 3) 
            {
                salarioSemanal = aula * 25;
            }
            else
            {
                Console.WriteLine("Esse nível não existe. Tente novamente.");
                return;
            }

            salarioMensal = salarioSemanal * 4;

            Console.WriteLine("O professor " + nome + " de nível " + nivel + " dá " + aula + " aulas por semana. Assim, recebe um salário de R$" + salarioSemanal + " por semana e R$" + salarioMensal + " por mês");
        }
    }
}

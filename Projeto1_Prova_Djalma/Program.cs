using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_Prova_Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nt1, nt2, notatrabalho, media;

            Console.Write(" Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("------------------------------------------------");

            Console.Write(" Digite a nota da sua primeira prova: ");
            nt1 = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            Console.Write(" Digite a nota da sua segunda prova: ");
            nt2 = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            Console.Write(" Digite a nota do seu trabalho: ");
            notatrabalho = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            media = (nt1 + nt2 + notatrabalho) / 3;

            if (media >= 8.5 && media <= 10)
            {
                Console.WriteLine( nome + " Sua média é equivalente ao conceito A.");
                Console.WriteLine("Média Final = " + media.ToString("F1"));
            }
            else if (media >= 7 && media <= 8.4)
            {
                Console.WriteLine( nome + "Sua média é equivalente ao conceito B.");
                Console.WriteLine("Média Final = " + media.ToString("F1"));
            }
            else if (media >= 6 && media <= 6.9)
            {
                Console.WriteLine( nome + "Sua média é equivalente ao conceito C.");
                Console.WriteLine("Média Final = " + media.ToString("F1"));
            }
            else if (media >= 0.1 && media <= 5.9)
            {
                Console.WriteLine( nome + "Sua média é equivalente ao conceito D.");
                Console.WriteLine("Média Final = " + media.ToString("F1"));

            }
            else if (media == 0)
            {
                Console.WriteLine( nome + "Sua média é equivalente ao conceito E.");
                Console.WriteLine("Média Final = " + media.ToString("F1"));
            }

            Console.ReadKey();

            

























        }
    }
}

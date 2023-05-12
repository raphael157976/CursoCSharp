using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class exercicio_2
    {
        public static void Executar()
        {

            Console.WriteLine("Digite a primeira nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double n2 = double.Parse(Console.ReadLine());

            double media = (n1 * 3.5 + n2 * 7.5) / 11;


            Console.WriteLine($"A média é de: {media}");





        }
    }
}

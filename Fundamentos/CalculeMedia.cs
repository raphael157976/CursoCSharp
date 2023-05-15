using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class CalculeMedia
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a primeria nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if (media >= 7)

            {
                Console.WriteLine("Aprovado:");
            }

            else if (media >= 5 && media < 7)

            {
                Console.WriteLine("Recuperação:");
            }

            else

            {
                Console.WriteLine("Recuperaçao:");
            }
        }
    }
}

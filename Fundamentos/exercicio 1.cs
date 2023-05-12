using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class exercicio_1
    {
        public static void Executar()
        {

            Console.WriteLine("Digite um número:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) /3 ;

            Console.WriteLine($"A média dos números é de: {media}");
        }
    }
}

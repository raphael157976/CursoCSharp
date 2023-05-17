using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class CodigoDDD
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o seu DDD:");
            int.TryParse(Console.ReadLine(), out int nota);



            switch (nota)
            {
                case 1:
                    Console.WriteLine("Péssimo");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom!");
                    break;
                case 5:
                    Console.WriteLine("Excelente");
                    break;
            }
        }
    }
}

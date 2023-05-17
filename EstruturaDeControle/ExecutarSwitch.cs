using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class ExecutarSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o seu DDD:");
            int.TryParse(Console.ReadLine(), out int nota);



            switch (nota)
            {
                case 11:
                    Console.WriteLine("São Paulo");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 27:
                    Console.WriteLine("Vitória");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 61:
                    Console.WriteLine("Brasília");
                    break;
                case 71:
                    Console.WriteLine("Salvador");
                    break;
                default:
                    Console.WriteLine("Nenhum DDD foi encontrado");
                    break;

            }
        }
    }
}


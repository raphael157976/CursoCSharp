using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Strings
    {
        public static void Executar()
        {
            Console.WriteLine("Digite uma senha:");
            


            var senha = (Console.ReadLine()); ;
            var senha2 = "7taz9HvJ";

                if (senha == senha2)

            {
                Console.WriteLine("acesso permitido:");
            }

                else
            {
                Console.WriteLine("acesso negado:");
            }

            



        }
    }
}

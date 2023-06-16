using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda2
    {
        public static void Executar()
        {
            Func<int,bool> ParEImpar = (total) =>
            {
                if (total %2 == 0)
                {
                    Console.WriteLine("O numero é par");

                    return true;
                }
                else { Console.WriteLine("O numero é impar");
                    return false;
                
                }               
                
            };

            Console.WriteLine(ParEImpar(4));
        }
    }
}

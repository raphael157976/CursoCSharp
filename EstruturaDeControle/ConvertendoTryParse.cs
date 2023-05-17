using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class ConvertendoTryParse
    {
            public static void Executar()

        {

            /* CONVERTENDO TRY PARSE */

            Console.WriteLine("Digite um número: ");

            string palavra = Console.ReadLine();

            int numero;

            int.TryParse(palavra, out numero);

            Console.WriteLine($"Resultado: {numero}");



            /*Enquanto o Parse faz a conversão da informação o TryParse verifica se é possivel 

             * converter para depois fazer a conversão*/

        }
    }
}

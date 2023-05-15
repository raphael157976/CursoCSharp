using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class MaiorIdade
    {

        public static void Executar()
        {
            Console.WriteLine("Digite o ano que você nasceu:");
            double n1 = double.Parse(Console.ReadLine());

            double idade = 2023 - n1;

            if (idade >= 18 && idade <= 70)
        { 
                Console.WriteLine($"Você pode votar: {idade}");
        }

            else            

        {
                Console.WriteLine($"Você não pode votar: {idade}");
        }




        }
    }
}

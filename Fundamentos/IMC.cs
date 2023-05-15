using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class IMC
    {
        public static void Executar()
        {

            Console.WriteLine("Digite o seu peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu altura:");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso/(altura * altura);

            if (IMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso:");
            }

            else if (IMC > 18.5 && IMC < 24.9)
            {
                Console.WriteLine("Peso normal:");
            }

            else if (IMC > 24.9 && IMC < 29.9)
            {
                Console.WriteLine("Acima do peso:");
            }

            else if (IMC > 29.9 && IMC < 34.9)
            {
                Console.WriteLine("Obesidade Grau I:");
            }

            else if (IMC > 34.9 && IMC < 39.9)
            {
                Console.WriteLine("Obesidade Grau II:");
            }

            else
            {
                Console.WriteLine("Obesidade Grau III:");
            }







        }
    }
}

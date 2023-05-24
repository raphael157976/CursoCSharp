using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosMetodosComRetorno
    {
        class CalculadoraComum2
        {
            public int Real(int a)
            {
                return a / 5;
            }

            public double Celsius (double b)
            {
                return b * 1.8 + 32;
            }
        }

        public static void Executar()
        {
            var calculadoraComum2 = new CalculadoraComum2();

            Console.WriteLine("Digite um valor em real para converter:");
            int a = int.Parse(Console.ReadLine());

            var resultado = calculadoraComum2.Real(20);

            Console.WriteLine($"O resultado foi de {resultado}");

            

            Console.WriteLine("Digite um número em Celsius para converter para Fahrenheit:");
            double b = double.Parse(Console.ReadLine());

            var resultado2 = calculadoraComum2.Celsius(20);

            Console.WriteLine($"O resultado foi de: {resultado2}");
            
        }
    }
}

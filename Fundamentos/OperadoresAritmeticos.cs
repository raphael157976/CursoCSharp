using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos {

        public static void Executar() {

            Console.WriteLine("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma entre esse dois números é de: {soma}");

            Console.WriteLine("Quanto é a base da triângulo?");
            double Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto é a altura da triângulo?");
            double altura = double.Parse(Console.ReadLine());

            double area = Base * altura / 2;

            Console.WriteLine($"A área desse triângulo é de: {area}");









        }
    }
}

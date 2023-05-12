using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class exercicio_3
    {
        public static void Executar()
        {

            Console.WriteLine("Digite o seu número:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite número de horas trabalhadas:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que recebe por hora:");
            double n3 = double.Parse(Console.ReadLine());

            double salario = n2 * n3;
            double nfuncionario = n1;



            Console.WriteLine($"Número do funcionário é: {nfuncionario}");
            Console.WriteLine($"Salário: {salario}");
        }
    }
}

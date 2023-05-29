using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetsESets
    {
        public class Pessoa
        {
            private string nome;
            private double altura;
            private int anoNascimento;

                public string Nome
            {
                get
                {
                    return nome;
                }

                set
                {
                    nome = value;
                }
            }


            public double Altura
            {
                get
                {
                    return altura;
                }

                set
                {
                    altura = value;
                }
            }

            public int AnoNascimento
            {
                get
                {
                    return anoNascimento;
                }

                set
                {
                    anoNascimento = value;
                }
            }

            public void imprimir()
            {
                Console.WriteLine($"Seu nome é {nome} e altura de {altura}");
            }

           public int CalculoIdade()
            {
                return anoNascimento - 2023;

            }

            public static void Executar()
            {
                var op = new Pessoa();
                var op2 = new Pessoa();

                Console.WriteLine(op.anoNascimento);
                Console.WriteLine(op2.anoNascimento);

            }


        }
    }
}

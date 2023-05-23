using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Cachorro
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Meu cachorro se chama {Nome} e tem {Idade} anos");
        }

        public void ApresentarNoConsole()
        {           
            Console.WriteLine(Apresentar());
        }
    }
}

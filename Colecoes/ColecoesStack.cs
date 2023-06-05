using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            //adicionando elementos na pilha
            pilha.Push(3);
            pilha.Push("A");
            pilha.Push(true);
            pilha.Push(3.14);

        }
    }
}

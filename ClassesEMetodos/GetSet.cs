using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {


        private string nome;


        public string Nome {

            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }

        }    

        public static void Executar()
        {
        /* vamos instanciar um objeto da nossa classe Cliente */
        Cliente cliente1 = new Cliente();

        /* Exemplo de GET cliente1.Nome; */

        //usando o SET para enviar uma informação
        cliente1.Nome = "Cleiton";

        Console.WriteLine(cliente1.Nome);

        }
    }
}

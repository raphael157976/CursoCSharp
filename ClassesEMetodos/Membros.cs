using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() {

            /*instanciando a classe pessoa
             * e criando um objeto*/
            /*estanciar uma classe*/

            //Pessoa pessoa1 = new Pessoa();

            //pessoa1.Nome = "Cleiton Peres";
            //pessoa1.Idade = 22;

            //Pessoa pessoa2 = new Pessoa();

            //pessoa2.Nome = "Manuel Gomes";
            //pessoa2.Idade = 57;


            //Console.WriteLine($"Olá {cachorro1.Nome} você tem {cachorro1.Idade} ");


            Cachorro cachorro = new Cachorro();

            cachorro.Nome = "Floco";
            cachorro.Idade = 9;




            //chamando o método Apresentar
            cachorro.ApresentarNoConsole();


        }
    }
}

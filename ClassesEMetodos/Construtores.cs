using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Cliente
    {
        //atributos de cliente
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

        //construtor personalizado
        public Cliente(string nome, string cpf, string sexo, string endereco, int idade) {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;
        }

        public Cliente()
        {

        }
    }

    //criando construtor padrão
    
    class Construtores { 
        public static void Executar()
        {
            /* new Cliente() é um construtor
            esse construtor é padrão e não recebe
            nenhum parâmetro */

            var cliente1 = new Cliente();
            cliente1.Nome = "Jonas";
            cliente1.Cpf = "6516515464";
            cliente1.Sexo = "H";
            cliente1.Endereco = "Vila Pires";
            cliente1.Idade = 70;

            //outra forma de chmar o construtor

            var cliente2 = new Cliente("Rogério Ceni", "12345678910", "M", "Ramiro Coleoni", 40);

            var cliente3 = new Cliente()
            {
                Nome = "Amanda",
                Sexo = "F",
                Endereco = "Avenida`Portugal",
                Idade = 25

            };

            Console.WriteLine($"Olá {cliente2.Nome} você é horrível e tem {cliente2.Idade} anos :(");

            
        }
    }
}

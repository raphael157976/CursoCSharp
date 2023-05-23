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

        public Cliente(string nome, string cpf, string sexo, string endereco, int idade) {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;
        }
    }

    //construtor personalizado
    
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
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class PrimeiraExcecao
    {
        public class Conta
        {
            private double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo Insuficiente");
                }
                //se usuário sacar um valor menor que o saldo
                //entao só subtraimos esse valor da conta dele
                Saldo -= valor;
            }
        }

        

        public static void Executar()
        {

        }      
    }
}

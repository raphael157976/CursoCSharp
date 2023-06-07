using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.POO
{
    class Heranca
    {

        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            //a velocidade maxima será transmitida por herença
            //por isso que estamos usando o protected
            int VelocidadeAtual;

            //criando o contrutor de carro
            public Carro(int velocidadeMaxima)
            {
                 VelocidadeMaxima = velocidadeMaxima;
            }

            //criando método para acelerar o carro
            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;
                if(novaVelocidade < 0)
                {
                    VelocidadeAtual = 0;
                }else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }

            public int Acelerar()
            {
                return AlterarVelocidade(5);
            }

            public int Frear()
            {
                return AlterarVelocidade(-5);
            }
        }
        
        //herança de Carro
        //ao colocar : estamos fazendo a herança 
        public class Uno : Carro
        {
            /*o número 200 que está entre base ()
            * signiica a velocidadeMáxima que foi herdado de carro
            usamos base para não precisa fazer o construtor novamente*/

            public Uno() : base(200)
            {

            }
        }

        public class Porsche : Carro
        {
            public Porsche() : base(300)
            {

            }
        }
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            //instanciar carro1 em Uno
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Porsche...");
            Porsche carro2 = new Porsche();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
        }
    }
}

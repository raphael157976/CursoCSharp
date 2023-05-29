using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.EstruturaDeControle
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"exercicio 1 - Fundamentos",exercicio_1.Executar},
                {"exercicio 2 - Fundamentos",exercicio_2.Executar},
                {"exercicio 3 - Fundamentos",exercicio_3.Executar},
                {"MaiorIdade - Fundamentos",MaiorIdade.Executar},
                {"Strings - Fundamentos",Strings.Executar},
                {"CalculeMedia - Fundamentos",CalculeMedia.Executar},
                {"IMC - Fundamentos",IMC.Executar},
                {"Executar Switch - Estrutura De Controle", ExecutarSwitch.Executar},
                {"Estrutura While e For - Estrutura De Controle", EstruturaWhileEFor.Executar},
                {"NumerosInteiros", NumerosInteiros.Executar},
                {"Estrutura Foreach", EstruturaForEach.Executar},


                //Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                {"Metodos com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Exercicios Metodos com Retorno - Classes e Métodos",ExerciciosMetodosComRetorno.Executar},
                {"Get e Set - Classes e Métodos",GetSet.Executar},
                {"Get e Set segundo exemplo - Classes e Métodos",GetESetSegundoExemplo.Executar},
                {"Gets e Sets - Classes e Métodos",GetsESets.Executar}
            }) ;

            central.SelecionarEExecutar();
        }
    }
}
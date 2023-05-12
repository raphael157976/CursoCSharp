using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;

namespace CursoCSharp {
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
                {"exercicio 3 - Fundamentos",exercicio_3.Executar}

            }) ;

            central.SelecionarEExecutar();
        }
    }
}
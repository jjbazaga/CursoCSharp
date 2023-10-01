using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClasseEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                { "Primeiro Programa -  Fundamentos", PrimeiroPrograma.Executar  },
                { "Cometarios - Fundamentos", Comentarios.Executar},
                { "Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                { "Inferencia - Fundamentos", Inferencia.Executar },
                { "Interpolação - Fundamentos", Interpolacao.Executar },
                { "Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                { "Lendo Dados - Fundamentos", LendoDados.Executar },
                { "Formatando Numero - Fundamentos", FormatandoNumero.Executar },
                { "Conversão - Fundamentos", Conversao.Executar },
                { "Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar },
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                { "Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                { "Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar },
                { "Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                { "Operadores Ternário - Fundamentos", OperadorTernario.Executar },

                // Estrutura de Controles
                { "Estrutura If - Estrutura de Controles", EstruturaIf.Executar },
                { "Estrutura If Else - Estrutura de Controles", EstruturaIfElse.Executar },
                { "Estrutura If Else If - Estrutura de Controles", EstruturaIfElseIf.Executar },
                { "Estrutura Switch - Estrutura de Controles", EstruturaSwitch.Executar },
                { "Estrutura While - Estrutura de Controles", EstruturaWhile.Executar },
                { "Estrutura Do While - Estrutura de Controles", EstruturaDoWhile.Executar },
                { "Estrutura For - Estrutura de Controles", EstruturaFor.Executar },
                { "Estrutura ForEach - Estrutura de Controles", EstruturaForEach.Executar },
                { "Usando Break - Estrutura de Controles", UsandoBreak.Executar },
                { "Usando Continue - Estrutura de Controles", UsandoContinue.Executar },

                // Classes e membros
                { "Membros - Classes e Metódos", Membros.Executar },
                { "Construtores - Classes e Metódos", Construtores.Executar },
                { "Metódos com Retorno - Classes e Metódos", MetodosComRetorno.Executar },
                { "Metódos Estáticos - Classes e Metódos", MetodosEstaticos.Executar },
                { "Atributos Estáticos - Classes e Metódos", AtributosEstaticos.Executar },
                { "Desafio Atributos - Classes e Metódos", DesafioAtributos.Executar },
                { "Params - Classes e Metódos", Params.Executar },
                { "Parametros Nomeados - Classes e Metódos", ParametrosNomeados.Executar },
                { "Getters e Setters - Classes e Metódos", GetSet.Executar },
                { "Propriedades - Classes e Metódos", Props.Executar },
                { "Readonly - Classes e Metódos", Readonly.Executar },
                { "Enumerações - Classes e Metódos", ExemploEnum.Executar },
                { "Structs - Classes e Metódos", ExemploStruct.Executar },
                { "Struct Vs Classe - Classes e Metódos", StructVsClasse.Executar },
                { "Valor Vs Referência - Classes e Metódos", ValorVsReferencia.Executar },
                { "Parametros por Referencia - Classes e Metódos", ParametrosPorReferencia.Executar },
                { "Parametro Padrão - Classes e Metódos", ParametroPadrao.Executar },

                // Coleções
                { "Array - Coleções", Colecoes.Array.Executar },
                { "Coleções List - Coleções", ColecoesList.Executar },
                { "Coleções Array List - Coleções", ColecoesArrayList.Executar },
                { "Coleções Set - Coleções", ColecoesSet.Executar },
                { "Coleções Queue(fila) - Coleções", ColecoesQueue.Executar },
                { "Coleções Igualdade - Coleções", Igualdade.Executar },
                { "Coleções Stack - Coleções", ColecoesStack.Executar },
                { "Coleções Dictionary - Coleções", ColecoesDictionary.Executar },

                // Orientação a Objetos - OO
                { "Herança - Orientação Objetos - OO", Heranca.Executar },
                { "Construtor This - Orientação Objetos - OO", ConstrutorThis.Executar },
                { "Encapsulamento - Orientação Objetos - OO", OO.Encapsulamento.Executar },
                { "Polimorfismo - Orientação Objetos - OO", Polimorfismo.Executar },
                { "Abstract - Orientação Objetos - OO", Abstract.Executar },
                { "Interface - Orientação Objetos - OO", Interface.Executar },
                { "Selead - Orientação Objetos - OO", Sealead.Executar },

                // Metodos e Funções
                { "Exemplo Lambda - Metodos e Funções", ExemploLambda.Executar },
                { "Lambdas Como Delegates - Metodos e Funções", LambdasDelegate.Executar },
                { "Usando Delegates - Metodos e Funções", UsandoDelegates.Executar },
                { "Delegates Funções Anonimas - Metodos e Funções", DelegatesFunAnonima.Executar },
                { "Delegates Como Parametros - Metodos e Funções", DelegatesComoParametros.Executar },
                { "Métodos de Extensão - Metodos e Funções", MetodosDeExtensao.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
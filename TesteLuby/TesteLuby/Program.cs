using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLuby.LogicaDeProgramacao;

namespace TesteLuby
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new ExecutarLogicas(new Dictionary<string, Action>()
            {
                // Lógica de Programação
                  {"Calcular Fatorial", CalcularFatorial.Executar},
                  {"Calcular Premio", CalcularPremio.Executar},
                  {"Contar Números Primos", ContarNumerosPrimos.Executar},
                  {"Calcula Vogais", CalculaVogais.Executar},
                  {"Calcular Valor Com Desconto Formatado", CalcularValorComDescontoFormatado.Executar},
                  {"Calcular Diferenca Data", CalcularDiferencaData.Executar},
                  {"Obter Elementos Pares", ObterElementosPares.Executar},
                  {"Buscar Pessoa", BuscarPessoa.Executar},
                  {"Transformar Em Matriz", TransformarEmMatriz.Executar},
                  {"Obter Elementos Faltantes", ObterElementosFaltantes.Executar},

                 });

            central.SelecionarEExecutar();
        }
    }
}
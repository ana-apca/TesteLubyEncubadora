using System;
using System.Globalization;

namespace TesteLuby.LogicaDeProgramacao
{
    public class Datas
    {
        public int DiferencaData(string dataInicial, string dataFinal)
        {
            var dataInicialConvertida = DateTime.ParseExact(dataInicial, "ddMMyyyy", CultureInfo.InvariantCulture);
            var dataFinalConvertida = DateTime.ParseExact(dataFinal, "ddMMyyyy", CultureInfo.InvariantCulture);
            var totalDias = dataFinalConvertida - dataInicialConvertida;

            return totalDias.Days;
        }
    }


    class CalcularDiferencaData
    {

        public static void Executar()
        {
            Console.Write("Informe a data inicial:  ");
            var entrada = Console.ReadLine();

            Console.Write("Informe a data final:  ");
            var entrada1 = Console.ReadLine();

            var resultado = new Datas().DiferencaData(entrada, entrada1);
            Console.WriteLine(" A diferença de dias é: " + resultado);
            Console.ReadKey();
        }
    }
}

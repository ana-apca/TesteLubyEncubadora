using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLuby.LogicaDeProgramacao
{

    public class FormatarValor
    {
        public string ValorComDescontoFormatado(string valor, string porcentagemDesconto)
        {
            var limparCaractereValor = valor.Replace("R$", "");
            var limparCaracterePorcentagemDesconto = porcentagemDesconto.Replace("%", "");

            var valorConvertido = Convert.ToDecimal(limparCaractereValor);
            var porcentagemConvertido = Convert.ToDecimal(limparCaracterePorcentagemDesconto);

            var resultado = valorConvertido - (valorConvertido * (porcentagemConvertido / 100));

            return string.Format("{0:C2}", resultado);
        }
    }

    class CalcularValorComDescontoFormatado
    {
        public static void Executar()
        {
            Console.Write("Digite um valor:  ");
            var entrada = Console.ReadLine();
            
            Console.Write("Digite o valor do desconto:  ");
            var entrada1 = Console.ReadLine();

            var resultado = new FormatarValor().ValorComDescontoFormatado(entrada, entrada1);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}

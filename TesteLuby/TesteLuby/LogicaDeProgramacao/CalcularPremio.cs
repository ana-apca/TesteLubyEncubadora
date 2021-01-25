using System;

namespace TesteLuby.LogicaDeProgramacao
{
    public class Premio
    {
        private const double BASIC = 1.0;
        private const double VIP = 1.2;
        private const double PREMIUM = 1.5;
        private const double DELUXE = 1.8;
        private const double SPECIAL = 2.0;

        public double CalcularPremio(double valorPremio, string tipoPremio, int? fatorMultiplicacaoProprio)
        {
            var resultado = 0.0;

            if (valorPremio > 0)
            {
                if (fatorMultiplicacaoProprio.HasValue)
                {
                    resultado = valorPremio * fatorMultiplicacaoProprio.Value;
                }
                else
                {
                    if (tipoPremio == "basic")
                    {
                        resultado = valorPremio * BASIC;
                    }
                    if (tipoPremio == "vip")
                    {
                        resultado = valorPremio * VIP;
                    }
                    if (tipoPremio == "premium")
                    {
                        resultado = valorPremio * PREMIUM;
                    }
                    if (tipoPremio == "deluxe")
                    {
                        resultado = valorPremio * DELUXE;
                    }
                    if (tipoPremio == "special")
                    {
                        resultado = valorPremio * SPECIAL;
                    }
                }
            }
            return resultado;
        }
    }


    class CalcularPremio

    {
        public static void Executar()
        {
            var resultado = new Premio().CalcularPremio(100, "vip", null);
            Console.WriteLine(resultado);

            var resultado1 = new Premio().CalcularPremio(100, "basic", 3);
            Console.WriteLine(resultado1);

            Console.ReadKey();
        }
    }
}


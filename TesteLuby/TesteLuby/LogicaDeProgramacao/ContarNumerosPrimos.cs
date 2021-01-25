using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLuby.LogicaDeProgramacao
{

    public class Primos
    {
        private bool IsNumeroPrimo(int numero)
        {
            bool bPrimo = true;
            int fator = numero / 2;
            int i = 0;
            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    bPrimo = false;
            }
            return bPrimo;
        }

        public int ContarNumerosPrimos(int numero)
        {
            int count = 0;

            for (int i = 2; i <= numero; i++)
            {
                if (IsNumeroPrimo(i))
                {
                    count++;
                }
            }
            return count;
        }
    }
    class ContarNumerosPrimos
    {
        public static void Executar()
        {
            Console.Write("Informe um número: ");
            int.TryParse(Console.ReadLine(), out int entrada);

            var resultado = new Primos().ContarNumerosPrimos(entrada);
            Console.WriteLine("Total de números primos: " + resultado);
            Console.ReadKey();
        }
    }
}

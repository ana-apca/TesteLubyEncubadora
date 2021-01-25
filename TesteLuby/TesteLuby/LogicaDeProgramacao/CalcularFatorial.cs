using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLuby.LogicaDeProgramacao
{
    class Fatorial
    {
        public int CalcularFatorial(int entrada)
        {
            int x = 1;
            for (int i = 1; i < entrada; i++)
            {
                x = x * (i + 1);
            }
            return x;
        }
    }
    class CalcularFatorial
    {
        public static void Executar()
        {
            Console.Write("Informe um número: ");
            int.TryParse(Console.ReadLine(), out int entrada);

            var calculaFatorial = new Fatorial();
            var resultado = calculaFatorial.CalcularFatorial(entrada);            
            Console.WriteLine("O calculo fatrial de " + entrada + " é " + resultado);           
            Console.ReadKey();

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLuby.LogicaDeProgramacao
{
    public class ElementosPares
    {
        public int[] Pares(int[] lista)
        {
            List<int> numerosPares = new List<int>();

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    numerosPares.Add(lista[i]);
                }
            }

            return numerosPares.ToArray();
        }
    }


    class ObterElementosPares
    {
        public static void Executar()
        {
            int[] vetor = new int[] { 1, 2, 3, 4, 5 };

            var resultado = new ElementosPares().Pares(vetor);
            Console.WriteLine(" São elementos pares: " + string.Join(", ", resultado));
            Console.ReadKey();
        }
    }
}

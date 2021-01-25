using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLuby.LogicaDeProgramacao
{
    public class ElementosFaltantes
    {
        public int[] ObterDiferenca(int[] vetor1, int[] vetor2)
        {

            var teste1 = vetor1.Except(vetor2).ToArray();
            var teste2 = vetor2.Except(vetor1).ToArray();

            var z = new int[teste1.Length + teste2.Length];


            if (teste1.Length > 0)
            {
                teste1.CopyTo(z, 0);
                teste2.CopyTo(z, teste1.Length);
            }
            else
            {
                teste2.CopyTo(z, 0);
                teste1.CopyTo(z, teste2.Length);
            }


            return z;
        }
    }
    class ObterElementosFaltantes
    {
        public static void Executar()
        {
            // faltam elementos no vetor2
            int[] vetor1 = new int[] { 1, 2, 3, 4, 5 };
            int[] vetor2 = new int[] { 1, 2, 5 };           

            // faltam elementos no vetor3
            int[] vetor3 = new int[] { 1, 4, 5 };
            int[] vetor4 = new int[] { 1, 2, 3, 4, 5 };

            // faltam elementos em ambos vetores
            int[] vetor5 = new int[] { 1, 2, 3, 4 };
            int[] vetor6 = new int[] { 2, 3, 4, 5 };

            // não faltam items
            int[] vetor7 = new int[] { 1, 3, 4, 5 };
            int[] vetor8 = new int[] { 1, 3, 4, 5 };

            var resultado = new ElementosFaltantes().ObterDiferenca(vetor1, vetor2);
            Console.WriteLine("Elementos faltantes: " + string.Join(", ", resultado));

            var resultado1 = new ElementosFaltantes().ObterDiferenca(vetor3, vetor4);
            Console.WriteLine("Elementos faltantes: " + string.Join(", ", resultado1));

            var resultado2 = new ElementosFaltantes().ObterDiferenca(vetor5, vetor6);
            Console.WriteLine("Elementos faltantes: " + string.Join(", ", resultado2));

            var resultado3 = new ElementosFaltantes().ObterDiferenca(vetor7, vetor8);
            Console.WriteLine("Elementos faltantes: " + string.Join(", ", resultado3));

            Console.ReadKey();
        }
    }
}

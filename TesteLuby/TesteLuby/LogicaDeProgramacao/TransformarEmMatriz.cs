using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLuby.LogicaDeProgramacao
{

    public class ListaParaMatriz
    {
        public int[][] ListaEmMatriz(string lista)
        {
            var arrayInteiro = lista.Split(',');

            int[][] matriz = new int[][]
            {
                new int[] {Convert.ToInt32(arrayInteiro[0]),Convert.ToInt32(arrayInteiro[1])},
                new int[] {Convert.ToInt32(arrayInteiro[2]),Convert.ToInt32(arrayInteiro[3])},
                new int[] { Convert.ToInt32(arrayInteiro[4]), Convert.ToInt32(arrayInteiro[5])}
            };

            return matriz;
        }
    }


    class TransformarEmMatriz
    {
        public static void Executar()
        {
            var resultado = new ListaParaMatriz().ListaEmMatriz("1,2,3,4,5,6");

            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine(" Array " +(i) + " Array " +(i) + "Array " +(i));
            }

            Console.ReadKey();
        }
    }
}

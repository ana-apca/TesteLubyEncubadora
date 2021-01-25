using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLuby.LogicaDeProgramacao
{
    public class Vogais
    {
        public int ContarVogais(char[] palavra)
        {
            var count = 0;
            char[] vogais = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'á', 'â', 'ã', 'é', 'ê', 'í', 'ó', 'ô', 'ú' };

            for (int i = 0; i < palavra.Length; i++)
            {
                if (vogais.Contains(palavra[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }

    class CalculaVogais
    {

        public static void Executar()
        {
            Console.Write("Digite uma palavra: ");
            var entrada = Console.ReadLine().ToLower().ToCharArray();

            var resultado = new Vogais().ContarVogais(entrada);
            Console.WriteLine("Sua palavra contém: " + resultado + " vogais.");
            Console.ReadKey();
        }
    }
}

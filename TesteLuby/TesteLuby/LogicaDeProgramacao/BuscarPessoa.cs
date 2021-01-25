using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLuby.LogicaDeProgramacao
{
    public class Pessoa
    {
        public string[] Pessoas(string[] vetor, string nome)
        {
            List<string> resultado = new List<string>();

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].Contains(nome))
                {
                    resultado.Add(vetor[i]);
                }
            }
            return resultado.ToArray();
        }
    }

    class BuscarPessoa
    {
        public static void Executar()
        {
            string[] vetor = new string[]
            {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero"
            };

            Console.Write("Digite o nome:  ");
            var entrada = Console.ReadLine();

            var resultado = new Pessoa().Pessoas(vetor, entrada);
            Console.WriteLine(" Nomes encontrados: " + string.Join(", ", resultado));
            Console.ReadKey();
        }


    }
}

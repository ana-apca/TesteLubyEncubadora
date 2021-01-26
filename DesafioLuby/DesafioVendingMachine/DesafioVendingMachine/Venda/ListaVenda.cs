using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioVendingMachine.Venda
{
    public class ListaVenda
    {
        private List<Venda> ListaVendas { get; set; }
        public ListaVenda()
        {
            ListaVendas = new List<Venda>();
        }

        public void VendaFinalizada(Venda venda)
        {
            ListaVendas.Add(venda);
        }

        public string ResumoVenda()
        {
            StringBuilder resumo = new StringBuilder();

            var produtosVendidos = ListaVendas.SelectMany(v => v.DetalheVenda).GroupBy(g => g.Cod);
            var TotalVenda = ListaVendas.SelectMany(v => v.DetalheVenda).Sum(p => p.ValorProduto);


            foreach (var pedido in produtosVendidos)
            {
                resumo.AppendLine($"{pedido.ToList().FirstOrDefault().Descricao}        {pedido.ToList().Count()}     {pedido.ToList().FirstOrDefault().ValorProduto}     {pedido.ToList().Sum(s => s.ValorProduto)}");
            }

            resumo.AppendLine();
            resumo.AppendLine($"Venda total: {ListaVendas.SelectMany(v => v.DetalheVenda).Sum(s => s.ValorProduto)}");

            return resumo.ToString();
        }
    }
}
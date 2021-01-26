using DesafioVendingMachine.Produtos;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioVendingMachine.Venda
{
    public class DetalhePedido : IControleEstoque
    {
        private List<Produto> ItensPedido { get; set; }

        public DetalhePedido()
        {
            ItensPedido = new List<Produto>();
        }

        public decimal TotalPedido()
        {
            return ItensPedido.Sum(p => p.ValorProduto);
        }

        public void CancelarPedido()
        {
            ItensPedido.Clear();
        }

        public void LimparPedido()
        {
            ItensPedido.Clear();
        }

        public void RemoverItem(Produto produto)
        {
            ItensPedido.Remove(produto);
        }

        public void SelecionarItem(Produto produto)
        {
            ItensPedido.Add(produto);
        }

        public List<Produto> Pedido()
        {
            return ItensPedido;
        }

        public string ResumoPedido()
        {
            StringBuilder resumo = new StringBuilder();
            foreach (var item in ItensPedido)
            {
                resumo.AppendLine($"{item.Descricao}    {item.ValorProduto}");
            }

            resumo.AppendLine();
            resumo.AppendLine($"Total Pedido: {ItensPedido.Sum(s=>s.ValorProduto)}");

            return resumo.ToString();
        }
    }
}
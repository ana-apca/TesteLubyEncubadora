using DesafioVendingMachine.Produtos;
using System.Collections.Generic;
using System.Linq;

namespace DesafioVendingMachine.Venda
{
    public class RegistrarVenda : IControleEstoque
    {
        private List<Produto> ProdutosDisponiveis { get; set; }
        private ListaVenda Vendas { get; set; }

        public DetalhePedido DetalhePedido { get; set; }

        public RegistrarVenda(List<Produto> produtosDisponiveis)
        {
            ProdutosDisponiveis = produtosDisponiveis;
            Vendas = new ListaVenda();
            DetalhePedido = new DetalhePedido();
        }

        public void RemoverItem(Produto produto)
        {
            ProdutosDisponiveis.Add(produto);
            DetalhePedido.RemoverItem(produto);
        }

        public void CancelarPedido()
        {
            ProdutosDisponiveis.AddRange(DetalhePedido.Pedido());
            DetalhePedido.CancelarPedido();
        }

        public void SelecionarItem(Produto produto)
        {
            if (ProdutosDisponiveis.Any(p => p.Cod == produto.Cod))
            {
                DetalhePedido.SelecionarItem(produto);
                var remove = ProdutosDisponiveis.Where(w=>w.Cod == produto.Cod).FirstOrDefault();
                ProdutosDisponiveis.Remove(remove);
            }
        }

        public (int disponibilidade, decimal valor) ResumoProduto(Bebida bebida)
        {
            var estoque = ProdutosDisponiveis.Where(p => p.Cod == bebida);

            return estoque.Count() > 0 ? (estoque.Count(), estoque.FirstOrDefault().ValorProduto) : (0, 0M);
        }

        public decimal TotalPedido()
        {
            return DetalhePedido.TotalPedido();
        }

        public string FinalizarVenda(decimal valorPago)
        {
            var totalPedido = TotalPedido();
            var resultado = string.Empty;
            if (valorPago < totalPedido)
            {
                resultado = "Complete o total do pedido.";
            }
            else
            {
                Vendas.VendaFinalizada(new Venda(DetalhePedido.Pedido()));
                var troco = valorPago - totalPedido;
                resultado = "Seu troco é " + troco;
            }
            return resultado;
        }

        public string ResumoDeVenda()
        {
            return Vendas.ResumoVenda();
        }
    }
}
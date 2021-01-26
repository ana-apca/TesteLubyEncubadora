using DesafioVendingMachine.Produtos;

namespace DesafioVendingMachine.Venda
{
    public interface IControleEstoque
    {
        void CancelarPedido();
        void RemoverItem(Produto produto);
        void SelecionarItem(Produto produto);
    }
}

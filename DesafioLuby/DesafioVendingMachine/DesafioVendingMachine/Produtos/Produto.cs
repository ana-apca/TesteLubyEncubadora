namespace DesafioVendingMachine.Produtos
{
    public abstract class Produto
    {
        public Bebida Cod { get; set; }
        public string Descricao { get; set; }
        public decimal ValorProduto { get; set; }
    }
    public enum Bebida
    {
        COCA = 0,
        CERVEJA = 1,
        SUCO = 3
    }
}
using DesafioVendingMachine.Produtos;
using System;
using System.Collections.Generic;

namespace DesafioVendingMachine.Venda
{
    public class Venda
    {
        public DateTime DataVenda { get; set; }
        public List<Produto> DetalheVenda { get; set; }

        public Venda(List<Produto> detalheVenda)
        {
            DataVenda = DateTime.Today;
            DetalheVenda = detalheVenda;
        }
    }
}
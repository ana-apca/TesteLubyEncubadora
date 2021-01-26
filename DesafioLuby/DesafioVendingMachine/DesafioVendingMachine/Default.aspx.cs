using DesafioVendingMachine.Produtos;
using DesafioVendingMachine.Venda;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace DesafioVendingMachine
{
    public partial class _Default : Page
    {
        public RegistrarVenda RegistrarVenda
        {
            get { return Session["RegistrarVenda"] as RegistrarVenda; }
            set { Session["RegistrarVenda"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Produto> produtosDisponiveis = new List<Produto>()
            {
                new Refrigerante(),
                new Refrigerante(),
                new Refrigerante(),
                new Refrigerante(),
                new Refrigerante(),
                new Cerveja(),
                new Cerveja(),
                new Cerveja(),
                new Cerveja(),
                new Cerveja(),
                new Suco(),
                new Suco(),
                new Suco(),
                new Suco(),
                new Suco(),
            };

                RegistrarVenda = new RegistrarVenda(produtosDisponiveis);
            }

            DetalhesProduto();
        }

        private void DetalhesProduto()
        {
            btnCoca.Text = DetalhesProduto(Bebida.COCA);
            btnCerveja.Text = DetalhesProduto(Bebida.CERVEJA);
            btnSuco.Text = DetalhesProduto(Bebida.SUCO);
        }

        private string DetalhesProduto(Bebida bebida)
        {
            var resumo = RegistrarVenda.ResumoProduto(bebida);
            string texto = $"Qtde. {resumo.disponibilidade} Valor R$ {resumo.valor}";
            return texto;
        }

        protected void btnCoca_Click(object sender, EventArgs e)
        {
            RegistrarVenda.SelecionarItem(new Refrigerante());
            btnCoca.Text = DetalhesProduto(Bebida.COCA);
            resumoDoPedido.InnerText = RegistrarVenda.DetalhePedido.ResumoPedido();
        }

        protected void btnCerveja_Click(object sender, EventArgs e)
        {
            RegistrarVenda.SelecionarItem(new Cerveja());
            btnCerveja.Text = DetalhesProduto(Bebida.CERVEJA);
            resumoDoPedido.InnerText = RegistrarVenda.DetalhePedido.ResumoPedido();
        }

        protected void btnSuco_Click(object sender, EventArgs e)
        {
            RegistrarVenda.SelecionarItem(new Suco());
            btnSuco.Text = DetalhesProduto(Bebida.SUCO);
            resumoDoPedido.InnerText = RegistrarVenda.DetalhePedido.ResumoPedido();
        }

        protected void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            RegistrarVenda.CancelarPedido();
            DetalhesProduto();
            resumoDoPedido.InnerText = string.Empty;
        }

        protected void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            var valorAPagar = txtValorAPagar.Text;
            var msg = RegistrarVenda.FinalizarVenda(Convert.ToDecimal(valorAPagar));
            Response.Write($"<script>alert('{msg}');</script>");
            resumoDoPedido.InnerText = string.Empty;
            txtValorAPagar.Text = string.Empty;
        }

        protected void btnExibirTotalVendas_Click(object sender, EventArgs e)
        {
            resumoDeVendas.InnerText = RegistrarVenda.ResumoDeVenda();
        }
    }
}
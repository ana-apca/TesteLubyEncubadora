<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DesafioVendingMachine._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="navbar navbar-default">
        <h2>Vending Machine</h2>
        <p class="lead">Selecione seus produtos...</p>
       
    </div>

        <div class="row">
        <div class="col-md-4">
            <asp:Image ID="ImageCoca" runat="server" ImageUrl="~/Imagens/coca350ml.png" />
            <asp:Button ID="btnCoca" runat="server" class="btn btn-primary btn-md" Text="Coca" OnClick="btnCoca_Click" />
        </div>
        <div class="col-md-4">
            <asp:Image ID="ImageCerveja" runat="server" ImageUrl="~/Imagens/carveja473ml.png" />
            <asp:Button ID="btnCerveja" runat="server" class="btn btn-primary btn-md" Text="Cerveja" OnClick="btnCerveja_Click" />
        </div>
        <div class="col-md-4">
            <asp:Image ID="ImageSuco" runat="server" ImageUrl="~/Imagens/suco330ml.png" />
            <asp:Button ID="btnSuco" runat="server" class="btn btn-primary btn-md" Text="Suco" OnClick="btnSuco_Click" />
        </div>
    </div>
    <br />
    <div>        
        <asp:Label ID="Label1" runat="server" Text="Resumo do Pedido"></asp:Label>
        <br />
        <textarea id="resumoDoPedido" runat="server" cols="50" rows="20"></textarea>
    </div>
    <asp:TextBox ID="txtValorAPagar" runat="server"></asp:TextBox>
    <asp:Button ID="btnFinalizarCompra" runat="server" class="btn btn-primary btn-sm" Text="Finalizar Compra" OnClick="btnFinalizarCompra_Click"/>
    <asp:Button ID="btnCancelarVenda" runat="server" class="btn btn-primary btn-sm" Text="Cancelar Venda" OnClick="btnCancelarVenda_Click" />
    <br />
    <br />
    <br />
    <div>       
        <asp:Label ID="Label2" runat="server" Text="Resumo de Vendas"></asp:Label>
        <br />
        <textarea id="resumoDeVendas" runat="server" cols="50" rows="20"></textarea>
    </div>
    <asp:Button ID="btnExibirTotalVendas" runat="server" Text="Total de Vendas" OnClick="btnExibirTotalVendas_Click"/>

    <br />



</asp:Content>

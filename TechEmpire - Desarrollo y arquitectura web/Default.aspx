<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TechEmpire___Desarrollo_y_arquitectura_web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="d-flex flex-column">
            <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
            <h1>Tech Empire</h1>
            <div >
                <asp:TextBox ID="txtBuscarProducto" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />

            </div>
        </section>
        <hr />
        
        

        <br />
        <div class="d-flex flex-wrap gap-3">
        <asp:Repeater ID="rptProductos" runat="server">
            <ItemTemplate>
                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Nombre") %></h5>
                        <p class="card-text">Precio: $<%# Eval("Precio") %></p>
                        <asp:Button ID="btnAgregarCarrito" runat="server" Text="Agregar al carrito" CssClass="btn btn-success" CommandArgument='<%# Eval("CodigoProducto") %>' />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>



</div>
    </main>

</asp:Content>

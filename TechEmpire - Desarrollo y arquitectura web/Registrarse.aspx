<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="TechEmpire___Desarrollo_y_arquitectura_web.RegistrarUsuario" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Registrarse</h1>
         <div class="d-flex flex-column">
            <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre de Usuario" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="d-flex flex-column">
            <asp:Label ID="lblClave" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="d-flex flex-column">
            <asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label>
            <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
        </div>
        <div class="d-flex flex-column">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="d-flex flex-column">
            <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="d-flex flex-column">
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
        </div>
        <asp:Button ID="btnCrearCuenta" runat="server" Text="Crear cuenta" CssClass="btn btn-success" OnClick="btnCrearCuenta_Click" />
    </div>
</asp:Content>
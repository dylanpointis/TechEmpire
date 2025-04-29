<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TechEmpire___Desarrollo_y_arquitectura_web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div  id="login" runat="server" class="form-group d-flex flex-column gap-3"> 
        <div class="d-flex flex-column">
            <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre de Usuario" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="d-flex flex-column">
            <asp:Label ID="lblClave" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesión" CssClass="btn btn-primary"  OnClick="btnLogin_Click" />
            <br />
            <p>¿No tienes una cuenta?</p>
            <asp:Button ID="btnRegistrar" runat="server" Text="Crear cuenta" CssClass="btn btn-success"  OnClick="btnRegistrar_Click" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="" CssClass="text-danger"></asp:Label>
        </div>
    </div>
</asp:Content>
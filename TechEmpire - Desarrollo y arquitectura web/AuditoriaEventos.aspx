<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AuditoriaEventos.aspx.cs" Inherits="TechEmpire___Desarrollo_y_arquitectura_web.AuditoriaEventos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

       <main>

        <asp:GridView ID="gvEventos" runat="server" AutoGenerateColumns="false" CssClass="table">
            <Columns>
                <asp:BoundField DataField="CodEvento" HeaderText="Código" />
                <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
                <asp:BoundField DataField="Modulo" HeaderText="Módulo" />
                <asp:BoundField DataField="evento" HeaderText="Evento" />
                <asp:BoundField DataField="Criticidad" HeaderText="Criticidad" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" ControlStyle-Width="100px" />
                <asp:BoundField DataField="Hora" HeaderText="Hora" />
            </Columns>
        </asp:GridView>
    
       </main>
</asp:Content>

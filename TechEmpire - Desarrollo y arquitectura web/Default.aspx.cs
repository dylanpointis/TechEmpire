using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BLL;

namespace TechEmpire___Desarrollo_y_arquitectura_web
{
    public partial class _Default : Page
    {
        private BLLProducto bllProd = new BLLProducto();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<BEProducto> listaProductos = bllProd.TraerListaProducto();
            if (!IsPostBack)
            {
                
                gvProductos.DataSource = listaProductos;
                gvProductos.DataBind();

                rptProductos.DataSource = listaProductos;
                rptProductos.DataBind();


                BEUsuario user = Session["User"] as BEUsuario;
                if (user != null)
                {
                    lblUser.Text = $"Bienvenido {user.NombreUsuario}";
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/About.aspx");
        }







        /*
         * <asp:GridView ID="gvProductos" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false">
            <Columns>   
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" />
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:Button ID="btnAgregarCarrito" runat="server" Text="Agregar al carrito" CssClass="btn btn-success" CommandArgument='<%# Eval("ID") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
         * */
    }
}
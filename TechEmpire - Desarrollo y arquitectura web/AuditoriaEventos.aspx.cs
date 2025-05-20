using BE;
using BLL;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechEmpire___Desarrollo_y_arquitectura_web
{
    public partial class AuditoriaEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BEUsuario user = Session["User"] as BEUsuario;
            if (user == null || user.codRol != 1)
            {
                Response.Redirect("Login.aspx");
            }


            BLLEvento bLLEvento = new BLLEvento();

            List<Evento> events = bLLEvento.TraerListaEventos();

            gvEventos.DataSource = events;
            gvEventos.DataBind();
        }
    }
}
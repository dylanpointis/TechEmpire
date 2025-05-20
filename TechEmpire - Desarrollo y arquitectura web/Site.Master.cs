using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechEmpire___Desarrollo_y_arquitectura_web
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {

                BEUsuario user = Session["User"] as BEUsuario;
                if(user.codRol == 1)
                {

                    btnEventos.Visible = true;
                }
            }

        }
    }
}
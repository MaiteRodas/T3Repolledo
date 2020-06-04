using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Tp3RepolledoMaite
{
    public partial class AltaArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session.Add(Session.SessionID + "NombreBienvenida", txtemail.Text);
            }

            catch (Exception Ex)
            {
                Session["Error" + Session.SessionID] = "No agrego nada al carrito";
                Response.Redirect("Error.aspx");
            }
        }
       
      
    }
}
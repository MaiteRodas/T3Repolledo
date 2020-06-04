using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Tp3RepolledoMaite
{
    public partial class ListaArticulos : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try   
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.Listar();

                

                Session[Session.SessionID + "listaArticulos"] = listaArticulos;// así se guarda una lista


                if( !IsPostBack)
                {
                    /// contrala que no se haga un paso doble.
                    
                }

            }
            catch(Exception ex)
            {
                throw;
            }



        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}
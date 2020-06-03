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
    public partial class AgregarCarrito : System.Web.UI.Page
    {
       // public List<Articulo> ListadeCarrritos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                /* List<Articulo> ListaOriginal = (List<Articulo>)Session[Session.SessionID +"ListaAgregarCarrito"];
                 int articuloSeleccionado = Convert.ToInt32(Request.QueryString["idAr"]);
                Articulo articulo = ListaOriginal.Find(x => x.IdArticulo == articuloSeleccionado);
                 ListadeCarrritos = (List<Articulo>)Session["ListaAgregarCarrito"];
                 ListadeCarrritos.Add(articulo);
                 ListadeCarrritos = (List<Articulo>)Session["ListaAgregarCarrito"];
                  // ListadeCarrritos = (List<Articulo>)Session["ListaAgregarCarrito"];
                 Session[Session.SessionID +"ListaAgregarCarrito"];*/

                ArticuloNegocio negocio = new ArticuloNegocio();
                dvbListaFavoritos.DataSource = negocio.Listar();
                dvbListaFavoritos.DataBind();







            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = "No agrego nada al carrito";
                Response.Redirect("Error");
            }

        }
    }
}
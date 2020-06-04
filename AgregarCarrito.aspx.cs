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
        public List<Articulo> listadeCarrritos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
               
                 List<Articulo> listaOriginal = (List<Articulo>)Session[Session.SessionID +"listaArticulos"];
                 int articuloSeleccionado = Convert.ToInt32(Request.QueryString["agCar"]);
                 Articulo articulo = listaOriginal.Find(x => x.IdArticulo == articuloSeleccionado);
                 
                listadeCarrritos = (List<Articulo>)Session["ListadelCarrito"];
                if (listadeCarrritos == null) { listadeCarrritos = new List<Articulo>(); }
                   
                 listadeCarrritos.Add(articulo);
                Session[Session.SessionID + "ListadelCarrito"] = listadeCarrritos;// la guardo para actualizarlo

               /* ArticuloNegocio negocio = new ArticuloNegocio();
                dvbListaFavoritos.DataSource = negocio.Listar();
                dvbListaFavoritos.DataBind();*/







            }
            catch (Exception ex)
            {
               Session["Error" + Session.SessionID] = "No agrego nada al carrito";
                Response.Redirect("Error.aspx");
            }

        }
    }
}
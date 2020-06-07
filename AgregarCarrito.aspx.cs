using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
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
                
                listadeCarrritos = (List<Articulo>)Session[Session.SessionID + "ListadelCarrito"];/// obtengo la lista de favoritos
                

                var artiQuitar = Request.QueryString["idQuitar"];// para eliminar el articulo seleccionado

                if(artiQuitar != null)
                {
                    listadeCarrritos = (List<Articulo>)Session[Session.SessionID + "ListadelCarrito"];
                    Articulo articuloQuitar = listadeCarrritos.Find(x => x.IdArticulo == int.Parse(artiQuitar));
                    listadeCarrritos.Remove(articuloQuitar);
                }
                else if(Request.QueryString["agCar"]!=null)
                {
                    List<Articulo> listaOriginal = (List<Articulo>)Session[Session.SessionID + "listaArticulos"]; // lista original
                    int articuloSeleccionado = Convert.ToInt32(Request.QueryString["agCar"]);
                    Articulo articulo = listaOriginal.Find(x => x.IdArticulo == articuloSeleccionado);

                    if (listadeCarrritos == null)
                        listadeCarrritos = new List<Articulo>();

                    listadeCarrritos.Add(articulo);
                    Session[Session.SessionID + "ListadelCarrito"] = listadeCarrritos;// la guardo para actualizarlo
                    double total =+ articulo.Precio;

                }     

            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = "No agrego nada al carrito";
                Response.Redirect("Error.aspx");
            }

        }
    }
}
using Dominio;
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
    public partial class ArticulosDetails : System.Web.UI.Page
    {
        public Articulo articulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listarArticulo;
            try
            {
                listarArticulo = negocio.Listar();
                int articuloSeleccionado = Convert.ToInt32(Request.QueryString["idAr"]);
                articulo = listarArticulo.Find(x => x.IdArticulo == articuloSeleccionado);

                

            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}
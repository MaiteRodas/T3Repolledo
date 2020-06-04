<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaArticulos.aspx.cs" Inherits="Tp3RepolledoMaite.ListaArticulos" %>

<asp:Content runat="server" ID="ListaArticulos" ContentPlaceHolderID="ContentPlaceHolder1">
    <h1>Lista de Articulos</h1>
    <div class="container">
        <div class="row">
            <div class="card-columns" style="margin-left: 5px; margin-right: 5px;">

                <% foreach (var item in listaArticulos)
                    { %>
                <div class=" card " style="width: 18rem;">
                    <img src="<% = item.ImagenURL%> " class="card-img-top" alt="...">
                    <div class="card-boby">
                        <h5 class="card-title"><% =item.Nombre %> </h5>
                        <p class="card-txt"><%=item.Descripcion %></p>
                        <a href="ArticulosDetails.aspx?idAr=<% = item.IdArticulo.ToString() %>" class="btn btn-primary">Seleccionar</a>
                        <a href="AgregarCarrito.aspx?agCar=<% = item.IdArticulo.ToString() %>" class="btn btn-primary">Agregar</a>

                    </div>
                </div>
                <% } %>
            </div>

        </div>
    </div>





</asp:Content>





<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarCarrito.aspx.cs" Inherits="Tp3RepolledoMaite.AgregarCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Tus articulos seleccionados son: </h1>
    <div class="container">
        <div class="row">
            <div class="col">

                <table class="table">
                    <tr>
                        <td>Nombre</td>
                        <td>Tipo</td>
                        <td>Precio</td>
                        <td>Total</td>

                    </tr>


                    <%foreach (var art in listadeCarrritos)
                        {
                    %>

                    <tr>
                        <td><% =art.Nombre %></td>
                        <td><% =art.Descripcion %></td>
                        <td><% =art.Precio %></td>
                        
                        <td><a href="AgregarCarrito.aspx?idQuitar=<% = art.IdArticulo.ToString() %>" class="btn btn-primary">Quitar</a></td>
                    </tr>
                    <%}
                    %>
                </table>
            </div>
        </div>
    </div>



</asp:Content>








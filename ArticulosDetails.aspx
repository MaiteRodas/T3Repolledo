<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ArticulosDetails.aspx.cs" Inherits="Tp3RepolledoMaite.ArticulosDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card" style="width: 18rem;">
        <img src="<% = articulo.ImagenURL%>" class="card-img-top" alt="...">
        <div class="card-body">
            <asp:Label Text="Nombre del articulo:" runat="server" />
            <h5 class="card-title"><% =articulo.Nombre %></h5>
             <asp:Label Text="Descripción:" runat="server" />
            <p class="card-text"> <%=articulo.Descripcion %></p>
            <asp:Label Text="Precio:" runat="server" />
            <p class="card-text"> <%=articulo.Precio %></p>
            <asp:Label Text="Marca:" runat="server" />
            <p class="card-text"> <%=articulo.Marca %></p>
            <asp:Label Text="Categoría:" runat="server" />
            <p class="card-text"> <%=articulo.Categoria %></p>

            <a href="ListaArticulos.aspx?" class="btn btn-primary">Volver</a>

        </div>
    </div>

</asp:Content>

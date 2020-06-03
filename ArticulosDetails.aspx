<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ArticulosDetails.aspx.cs" Inherits="Tp3RepolledoMaite.ArticulosDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <div class="Card" style="width:25%">
            <img  src ="<% = articulo.ImagenURL%> "class = "card-img-top"  alt = "...">
            <div class="card-boby">
                <asp:Label Text="Nombre del articulo:" runat="server" />
        <h5 class="card-title"><% =articulo.Nombre %> </h5>
               <asp:Label Text="Descripción:" runat="server" />
           <p class="card-txt"> <%=articulo.Descripcion %></p>
                <asp:Label Text="Precio: S." runat="server" />
           <p class="card-Desc"> <%=articulo.Precio %></p>
                <asp:Label Text="Marca:" runat="server" />
           <p class="card-Marc"> <%=articulo.Marca %></p>
                <asp:Label Text="Categoría:" runat="server" />
           <p class="card-Desc"> <%=articulo.Categoria %></p>




    </div>
    </div>
</asp:Content>

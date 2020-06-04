<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarCarrito.aspx.cs" Inherits="Tp3RepolledoMaite.AgregarCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">

                <table class="table">
                    <tr>
                        <td>Nombre</td>
                        <td>Tipo</td>
                    </tr>


                    <%foreach (var art in listadeCarrritos)
                        {
                    %>

                    <tr>
                        <td><% =art.Nombre %></td>
                        <td><% =art.IdArticulo %></td>

                    </tr>
                    <%}
                    %>
                </table>
            </div>
        </div>
    </div>



</asp:Content>








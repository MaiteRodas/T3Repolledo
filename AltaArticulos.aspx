<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AltaArticulos.aspx.cs" Inherits="Tp3RepolledoMaite.AltaArticulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
        <div class="container">
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="exampleInputEmail1">Email address</label>
                        <asp:TextBox ID="txtemail" CssClass="form-control" runat="server"/>
                        <small id="emailHelp" class="form-text text-muted">Por favor Ingrese su e-mail</small>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1">Password</label>
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"/>
                    </div>

                    <asp:Button Text="Aceptar" ID="btnAceptar" cssClass="btn btn-primary"  runat="server"  />
                </div>
            </div>
            </div>
    </form>
</asp:Content>



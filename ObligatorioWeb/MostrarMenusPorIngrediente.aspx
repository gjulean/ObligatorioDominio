<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="MostrarMenusPorIngrediente.aspx.cs" Inherits="ObligatorioWeb.MostrarMenusPorIngrediente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<asp:Label ID="LblSelIngrediente" runat="server" Text="Seleccionar Ingrediente"></asp:Label>
&nbsp;&nbsp;
<asp:DropDownList ID="DDlIngredientesMenu" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDlIngredientesMenu_SelectedIndexChanged">
</asp:DropDownList>
<br />
<br />
<br />
<asp:GridView ID="GVMenuIngrediente" runat="server">
</asp:GridView>
&nbsp;
</asp:Content>

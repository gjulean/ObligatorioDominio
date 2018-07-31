<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="MenusConPrecio.aspx.cs" Inherits="ObligatorioWeb.MenusConPrecio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="LblMenuPrecio" runat="server" Text="MenusPrecios"></asp:Label>
&nbsp;&nbsp;
    <br />
    <br />
    <asp:GridView ID="GVMenuPrecios" runat="server">
    </asp:GridView>
&nbsp;<p>
        &nbsp;</p>
</asp:Content>

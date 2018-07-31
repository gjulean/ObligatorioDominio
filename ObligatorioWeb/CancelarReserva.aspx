<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="CancelarReserva.aspx.cs" Inherits="ObligatorioWeb.CancelarReserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
&nbsp;
    <asp:Label ID="LblCancelarReserva" runat="server" Text="Seleccionar reserva"></asp:Label>
&nbsp;&nbsp;
    <asp:DropDownList ID="DDlCancelarReserva" runat="server">
    </asp:DropDownList>
    <p>
    </p>
    <asp:Button ID="BtnCancelarReserva" runat="server" Text="Guardar" />
    <br />
    <p>
    </p>
    <asp:Label ID="LblMensajeCancelarReserva" runat="server"></asp:Label>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

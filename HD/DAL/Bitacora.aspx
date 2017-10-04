<%@ Page Title="" Language="C#" MasterPageFile="~/DAL/Site.Master" AutoEventWireup="true" CodeBehind="Bitacora.aspx.cs" Inherits="HD.DAL.Bitacora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <li><i class="ace-icon fa fa-home home-icon"></i>&nbsp;<a href = "default.aspx"> Inicio </a></li><li class="active"><i class="ace-icon fa fa-clock-o"></i>&nbsp;Bitácora</li><li><%=DateTime.Now.ToLongDateString() %></li>
</asp:Content>

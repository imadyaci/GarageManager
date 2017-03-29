<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProducts.aspx.cs" Inherits="Pages_Management_ManageProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Name:<br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <br />
    Type:<br />
    <asp:DropDownList ID="ddType" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    Price:<br />
    <asp:TextBox ID="textPrice" runat="server"></asp:TextBox>
    <br />
    <br />
    Image:<br />
    <asp:DropDownList ID="ddImage" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <br />
</asp:Content>


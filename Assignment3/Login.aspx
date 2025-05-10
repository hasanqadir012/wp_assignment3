<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment3.Login" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h3>Login</h3>
    <asp:TextBox ID="txtUsername" runat="server" Placeholder="Username" /><br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password" /><br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="login_Click" />
    <asp:Label ID="lblMessage" runat="server" ForeColor="Blue" />
</asp:Content>





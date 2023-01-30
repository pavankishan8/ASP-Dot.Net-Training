<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsheet.Master" AutoEventWireup="true" CodeBehind="RecipientPage.aspx.cs" Inherits="ProductWebApplication.RecipientPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1>The Contents entered by the User are: </h1>
    <hr />
    <asp:Label Text="" ForeColor="Red" ID="lblMessage" runat="server" />
</asp:Content>

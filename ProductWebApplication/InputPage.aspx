<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsheet.Master" AutoEventWireup="true" CodeBehind="InputPage.aspx.cs" Inherits="ProductWebApplication.InputPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h2>Input the User Information</h2>
    <hr />
    <div class="col-md-8" style="text-align: left">
        Enter the Name:
        <div class="col-md-8">
            <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
        </div>
    </div>
    <div class="col-md-8" style="text-align: left">
        Enter the Email:
        <div class="col-md-8">
            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
        </div>
    </div>

        <div class="col-md-8" style="text-align: left">
        Enter the Contact No:
        <div class="col-md-8">
            <asp:TextBox runat="server" ID="txtContact" CssClass="form-control" />
        </div>
    </div>
    <div>
        <asp:Button runat="server" CssClass="btn btn-primary" Text="Save Changes" OnClick="Unnamed1_Click" />
    </div>
</asp:Content>

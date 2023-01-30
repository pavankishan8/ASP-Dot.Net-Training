<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsheet.Master" AutoEventWireup="true" CodeBehind="Shopping Cart.aspx.cs" Inherits="ProductWebApplication.Shopping_Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
     <style>
        .item{
            border:2px solid blue;
        }
    </style>
    
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <asp:Repeater runat="server" ID="rpProducts">
        <HeaderTemplate>
            <div>
                <h2>List of items with Us!!!!</h2>
                <hr />
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row item">
                <div class="col-md-8">
                    <asp:Image ImageUrl=<%#Eval("Image")%> runat="server" height="200" Width="200" padding="25px"/>
                    <p>Price: <%#Eval("Price") %></p>
                    <p>
                    <asp:Button Text="View More" CommandName="Details" CommandArgument='<%#Eval("ProductId") %>' OnCommand="OnView_Command" runat="server" CssClass="btn btn-info"/>
                    </p>
                </div>
               

            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
            </div>
            <div class="col-md-4">
                <h2>Details of the Selected Product</h2>
                <div>
                    <asp:TextBox ID="txtProductId" runat="server" Enabled="false" />
                </div>
                <div>
                    <asp:TextBox ID="txtProductName" runat="server" Enabled="false" />
                </div>
                <div>
                    <asp:TextBox ID="txtProductCost" runat="server" Enabled="false" />
                </div>
                <div>
                    <asp:TextBox runat="server" ID="txtQuantity" Enabled="false" />   
                </div>
                <div>
                    <asp:Button Text="Add to Cart" runat="server" />
                </div>
            </div>
        </div>
        <div class="row">
            <asp:DataList ID="lstRecentList" runat="server" CellPadding="30" RepeatColumns="4">
                <ItemTemplate>
                    <div class="row item">
                        <div class="col-md-7">
                            <h5><%#Eval("ProductName")%></h5>
                            <asp:Image ImageUrl=<%#Eval("Image")%> runat="server" height="200" Width="200" />
                            <p>Price: <%#Eval("Price") %></p>
                        </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsheet.Master" AutoEventWireup="true" CodeBehind="DataCaching.aspx.cs" Inherits="ProductWebApplication.DataCaching" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div>   
        <asp:GridView ID="grdDetails" runat="server" BackColor="#CCCCCC" BorderColor="White" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="#0066FF" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="LightBlue" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div> 
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsheet.Master" AutoEventWireup="true" CodeBehind="Caching.aspx.cs" Inherits="ProductWebApplication.Caching" %> 
<%@ Register TagName="CustomControls" TagPrefix="myctrls" Src="~/CustomControls/Server.ascx" %>
<%--<%@ OutputCache Duration="60" VarybyParam="City"%>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

    <div style="border: 2px solid blue">
    <h1>Time at the Server</h1>
    <hr />
    <asp:Label Text="" ID="lblTime" runat="server" />
        </div>
    <hr/>
    <div style="border: 2px solid blue">
        <h2>Time at Various Places</h2>
        <hr />
    <p>
        Select your City:
            <asp:DropDownList runat="server" ID="dpCities">
                <asp:ListItem Text="New Delhi" />
                <asp:ListItem Text="London" />
                <asp:ListItem Text="New York" />
                <asp:ListItem Text="Tokyo" />
            </asp:DropDownList>

        <asp:Button Text="GetTime" runat="server" ID="btnTime" OnClick="btnTime_Click" />
        <asp:Label Text="" ID="lblClock" runat="server" />
    </p>
  </div>
    <hr />
    <div style="border: 2px solid blue">
        <h2>Fragment Caching</h2>
        <div style="text-align:center">
            <myctrls:CustomControls  runat="server">

            </myctrls:CustomControls>
        </div>
    </div>
</asp:Content>

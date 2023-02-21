<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebApiConsumer.aspx.cs" Inherits="WebApplication1.WebApiConsumer" %>

<%@ Register Src="~/Controls/DataComponent.ascx" TagName="dataCtrl" TagPrefix="data" %>

<asp:Content ContentPlaceHolderID="mainContent" runat="server">
    <data:dataCtrl runat="server" ID="myControl"/>

    <div>
        <asp:Label Text="" ID="lblData" runat="server" />
    </div>

</asp:Content>

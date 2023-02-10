<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="TransportApp.WebForms.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <div class="row">
        <div class="col-md-6" >
            <iframe width="100%" height="100%" src="https://www.google.com/maps/embed/v1/MAP_MODE?key=YOUR_API_KEY&PARAMETERS"></iframe>
        </div>
        <div class="col-md-6" style="border-style:solid; border-color:white; background-color:white">
            <div class="row">
                <div class="col-md-5" style="border: solid 5px; background-color: darkgrey; width: 230px; height: 240px; border-color:grey; margin: 50px 2px 2px 2px;">
                    <asp:Image ImageUrl="" ID="imgprew" runat="server" />
                </div>
                <div class="col-md-7">
                    <h2 style="text-align: center">Route Selection</h2>
                    <p>
                        <input id="txtid" type="text" placeholder="Employee ID" class="form-control; btn btn-outline-dark" style="width:308px">
                    </p>
                    <p>
                        <asp:DropDownList ID="txtroute" Width="308px" CssClass="btn btn-outline-dark" runat="server" AutoPostBack="True" OnSelectedIndexChanged="txtroute_SelectedIndexChanged"></asp:DropDownList>
                    </p>
                    <p>
                        <asp:DropDownList ID="txtPickup" Width="308px" CssClass="btn btn-outline-dark" runat="server"></asp:DropDownList>
                    </p>
                    <p>
                        <asp:DropDownList ID="txtDrop" Width="308px" CssClass="btn btn-outline-dark" runat="server"></asp:DropDownList>
                    </p>
                    <p style="text-align: center">
                        <button class="btn btn-success" id="btnUpdate" style="width: 250px; margin: 5px">Submit</button>

                    </p>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>

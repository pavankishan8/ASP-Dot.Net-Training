<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Site1.Master" AutoEventWireup="true" CodeBehind="RouteInformation.aspx.cs" Inherits="TransportApp.WebForms.RouteInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <div class="container">
        <div class="row">
            <h1 style="text-align:center; width:100%; height:60px; background-color:darksalmon; border:solid 2px white; border-radius:5px">Route Information</h1>
        </div>
        <hr />
        <div class="row">
            <div class="col-md-12">
                <table class=" table table-bordered table-columns table-hover"  style="border-style:solid; border-color:black; color:black">
                    <tr>
                        <th>Route No</th>
                        <th>Route Name</th>
                        <th>Amount</th>
                    </tr>
                </table>
            </div>
            
            </div>
    </div>
</asp:Content>

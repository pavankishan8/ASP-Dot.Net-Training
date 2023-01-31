<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="HospitalSoftware.WebForms.Billing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container">
        <div class="row">
            Enter the Patient ID:
            <asp:TextBox runat="server" ID="txtPatientId" CssClass="form-control" />
            <asp:Button Text="Fetch" ID="btnFetch" CssClass="btn btn-warning" runat="server" Height="40px" BorderStyle="Solid" BorderWidth="3px" BorderColor="White"/>
        </div>
        <div class="row">
            <h2 style="font-family: Aboreto; font-size: 30px; text-align: center;">Billing Details</h2>
            <hr />
            <div class="container">
                <div class="row">
                    <div class="col-md-8">
                        Bill No:
                        <asp:TextBox runat="server" Width="530px" ID="txtBillNo" Enabled="false" CssClass="form-control"/>
                    </div>
                    <div class="col-md-3">
                        Bill Date: 
                        <asp:TextBox CssClass="form-control" Width="260px" runat="server" ID="txtDate" TextMode="Date" Enabled="false" />
                    </div>
                </div>
            </div>
            <p>
                PatientName: 
                    <asp:TextBox Enabled="false" runat="server" ID="txtName" CssClass="form-control" Width="815"/>
            </p>
            <p>
                Mobile No:
                    <asp:TextBox Enabled="false" TextMode="Number" ID="txtMobile" CssClass="form-control" runat="server" Width="815"/>
            </p>
            <p>
                Doctor Name: 
                <asp:TextBox runat="server" ID="txtDoctor" Enabled="false" CssClass="form-control" Width="815"/>
            </p>
            <p>
                Bill Amount: 
                <asp:TextBox runat="server" ID="txtAmount" CssClass="form-control" Enabled="false" Width="815"/>
            </p>
            <p>
                <asp:Button Text="Generate Bill" runat="server" ID="btnBill" CssClass="btn btn-success" Width="815"/>
            </p>
        </div>

    </div>
</asp:Content>

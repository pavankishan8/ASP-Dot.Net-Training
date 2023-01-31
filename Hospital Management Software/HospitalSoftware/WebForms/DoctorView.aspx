<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="DoctorView.aspx.cs" Inherits="HospitalSoftware.WebForms.DoctorView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

    <h1 style="font-family: Aboreto; font-size: 30px; text-align: center;">List of Patients</h1>

    Select Doctor
    <asp:DropDownList runat="server" ID="dpDoctors" CssClass="form-control" Width="830px" AutoPostBack="True" OnSelectedIndexChanged="dpDoctors_SelectedIndexChanged">
    </asp:DropDownList>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <asp:TextBox runat="server" ID="txtSearch" TextMode="Search" CssClass="form-control" Width="255px"/>
                <br />
                <asp:ListBox runat="server" ID="lstPatients" Width="250px" Height="310px" BackColor="PowderBlue" AutoPostBack="True" OnSelectedIndexChanged="lstPatients_SelectedIndexChanged"></asp:ListBox>
            </div>
            <div class="col-md-8">
                <h2>Details of the Patient</h2>
                <p>
                    PatientId: 
                    <asp:TextBox Enabled="false" runat="server" ID="txtId" CssClass="form-control" Width="530px"/>
                </p>
                <p>
                    PatientName: 
                    <asp:TextBox Enabled="false" runat="server" ID="txtName" CssClass="form-control" Width="530px"/>
                </p>
                <p>
                    Mobile No:
                    <asp:TextBox Enabled="false" TextMode="Number" ID="txtMobile" CssClass="form-control" runat="server" Width="530px"/>
                </p>
                <p>
                    Age:
                    <asp:TextBox Enabled="false" TextMode="Number" ID="txtAge" CssClass="form-control" runat="server" Width="530px"/>
                </p>
                <p>
                    <asp:Button Text="Diagnose" runat="server" ID="btnDiagnose" CssClass="btn btn-primary" Width="530px"/>
                </p>
            </div>
        </div>
    </div>
</asp:Content>

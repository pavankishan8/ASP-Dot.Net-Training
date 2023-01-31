<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="RegisterPatient.aspx.cs" Inherits="HospitalSoftware.WebForms.RegisterPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
     <h1 style="font-family: Aboreto; font-size: 30px; text-align: center;">Patient Registration Form</h1>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-2">
                <p>
                    PatientId: 
                    <asp:TextBox runat="server" Enabled="false" placeholder="ID will be Auto-Generated" ID="txtId" CssClass="form-control" Width="810px"/>
                </p>
                <p>
                    PatientName: 
                    <asp:TextBox runat="server" ID="txtName" CssClass="form-control" Width="810px" />
                </p>
                <p>
                    Mobile No:
                    <asp:TextBox TextMode="Number" ID="txtMobile" CssClass="form-control" runat="server" Width="810px"/>
                </p>
                <p>
                    Date of Birth:
                    <asp:TextBox TextMode="Date" ID="txtDob" CssClass="form-control" runat="server" Width="810px"/>
                </p>
                <p>
                    DoctorName:
                    <asp:DropDownList runat="server" ID="dpDoctors" CssClass="form-control" Width="810px">
                    </asp:DropDownList>
                </p>
                <p>
                    <asp:Button Text="Register" runat="server" CssClass="btn btn-danger" Width="810px" OnClick="Unnamed1_Click1"/>
                </p>
               
                    <asp:Label ID="lblMessage" CssClass="alert-success" runat="server" ForeColor="#66FF33" /> 
               
            </div>
        </div>
    </div>
</asp:Content>

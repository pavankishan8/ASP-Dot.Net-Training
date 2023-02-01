<%@ Page Language="C#" MasterPageFile="~/Mainsheet.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProductWebApplication.WebForm1" %>

<asp:Content ContentPlaceHolderID="mainContent" runat="server">

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />

    <div>
        <h1 class="auto-style1"><span class="newStyle1">PRODUCT APPLICATION</span></h1>
    </div>

        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <asp:ListBox ID="lstProducts" runat="server" Height="330px" Width="171px" OnSelectedIndexChanged="lstProducts_SelectedIndexChanged" AutoPostBack="True" BackColor="#99CCFF" BorderColor="White" BorderStyle="Solid"></asp:ListBox>
                </div>

                <div class="col-md-7" <%--style="border:solid;--%>">
                    <h4>Details of the Product</h4>

                    <div class="row">
                        <div class="col-md-6">
                            <asp:Image ID="imgPic" Height="250px" runat="server" Width="200px" BackColor="#99CCFF" BorderColor="White" BorderStyle="Solid" />
                        </div>

                        <div class="col-md-5">
                            <p>Product Id:
                                <asp:TextBox runat="server" CssClass="form-control" ID="txtId" /></p>
                            <p>Name:<asp:TextBox CssClass="form-control" runat="server" ID="txtName" /></p>
                            <p>Price:<asp:TextBox CssClass="form-control" runat="server" ID="txtPrice" /></p>
                            <p>
                                Quantity:<asp:DropDownList CssClass="form-control" ID="dpQuantity" runat="server" Width="190px">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                </asp:DropDownList>
                            </p>

                        </div>

                        <div class="col-md-1 align-items-center">
                            <button runat="server" onserverclick="btnEdit_Click" class="btn btn-info m-2">
                                <i class="fa fa-pencil"></i>
                            </button>
                            <button onserverclick="btnDelete_Click" runat="server" class="btn btn-danger m-2">
                                <i class="fa fa-trash"></i>
                            </button>
                            <button onserverclick="btnAdd_Click" runat="server" class="btn btn-primary m-2">
                                <i class="fa fa-plus-circle"></i>
                            </button>
                        </div>

                            <div>
                            <asp:FileUpload ID="FileUpload1" CssClass="btn btn-success" Width="230px" runat="server"/>
                                
                            <asp:Button ID="Button1" runat="server" Text="Upload" CssClass="btn btn-success" OnClick="Button1_Click">
                            
                                </asp:Button>
                            <asp:Image ID="Image1" runat="server" />
                            </div>

                    </div>
                </div>
            </div>
        </div>
    </asp:Content>
<%@ Page Language="C#" MasterPageFile="~/Mainsheet.Master" AutoEventWireup="true" CodeBehind="ProductApp.aspx.cs" Inherits="ProductWebApplication.ProductApp" %>

<asp:Content ContentPlaceHolderID="mainContent" runat="server">

    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />

        <h1 class="auto-style1"><span class="newStyle1">PRODUCT APPLICATION</span></h1>
    

        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <asp:ListBox ID="lstProducts" runat="server" Height="330px" Width="171px" OnSelectedIndexChanged="lstProducts_SelectedIndexChanged" AutoPostBack="True" BackColor="#99CCFF" BorderColor="White" BorderStyle="Solid"></asp:ListBox>
                </div>

                <div class="col-md-7">
                    <h4>Details of the Product</h4>

                    <div class="row">
                        <div class="col-md-6">
                            <asp:Image ID="imgPic" Height="151px" runat="server" Width="140px" BackColor="#99CCFF" BorderColor="White" BorderStyle="Solid" />
                            <asp:FileUpload runat="server" ID="FileUpload1" />

                        </div>

                        <div class="col-md-4">
                            <p>Product Id:
                                <asp:TextBox runat="server" CssClass="form-control" ID="txtId" /></p>
                            <p>Name:<asp:TextBox CssClass="form-control" runat="server" ID="txtName" /></p>
                            <p>Price:<asp:TextBox CssClass="form-control" runat="server" ID="txtPrice" /></p>
                            <p>
                                Quantity:<asp:DropDownList CssClass="form-control" ID="dpQuantity" runat="server">
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


                    </div>
                </div>
            </div>
        </div>
    </asp:Content>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProductWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Aboreto;
        }

        .auto-style1 {
            text-align: center;
        }

        .my-3 {
        }
    </style>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />

</head>
<body>
    <div>
        <h1 class="auto-style1"><span class="newStyle1">PRODUCT APPLICATION</span></h1>
    </div>


    <form id="form1" runat="server">

        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <asp:ListBox ID="lstProducts" runat="server" Height="386px" Width="213px" OnSelectedIndexChanged="lstProducts_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                </div>

                <div class="col-md-7">
                    <h4>Details of the Product</h4>

                    <div class="row">
                        <div class="col-md-6">
                            <asp:Image ID="imgPic" Height="253px" runat="server" Width="225px" />
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
                            
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <asp:Button ID="Button1" runat="server"
                                Text="Upload" OnClick="Button1_Click" />
                            
                            <asp:Image ID="Image1" runat="server" />

                        </div>


                    </div>
                </div>
            </div>
        </div>
    </form>

</body>
</html>

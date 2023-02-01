<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProductWebApplication.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="Scripts/jquery-3.6.3.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <style type="text/css">
        body {
            background-image: url('./Images/background.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <h1 style="text-align: center">Pavan Kishan</h1>
        <hr />
        <div class="container">
            <div class="row">
                <div class="col-md-8">
                    <img src=".\Images\PavanR.jpg" alt="My Image" width="520" height="520" style="border: solid White; border-width: 5px; padding: 5px" />
                </div>
                 <div class="col-md-4">
                        <h2>User Login</h2>

                        <p>
                            User Name:
                <asp:TextBox runat="server" ID="txtUserName" Height="22px" Width="239px" />
                        </p>
                        <p>
                            Password:
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" Height="21px" Width="247px" />
                        </p>
                        <p>
                            <asp:Button Text="Login" runat="server" ID="btnLogin" CssClass="btn btn-danger" OnClick="btnLogin_Click" Width="325px" />

                        </p>
                        <p>
                            <asp:Label Text="" runat="server" ID="lblError" ForeColor="red" />
                        </p>


                    </div>
                
            </div>
        </div>
    </form>
</body>
</html>

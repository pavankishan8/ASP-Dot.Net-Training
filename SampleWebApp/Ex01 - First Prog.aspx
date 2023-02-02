<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex01 - First Prog.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: "Comic Sans MS";
            background-color: #FF9966;
            background-image: none;
            border: thin solid #3366FF;
            font-size: 40px;
        }
        .newStyle2 {
            font-family: "Times New Roman", Times, serif;
            line-height: normal;
            background-color: #CCFF99;
        }
        .newStyle3 {
            font-family: "Times New Roman", Times, serif;
            background-color: #CCFF99;
        }
        .newStyle4 {
            font-family: "Times New Roman", Times, serif;
            background-color: #CCFF99;
        }
        .newStyle5 {
            font-family: "Comic Sans MS";
            background-color: #FF9966;
            border-style: double;
            border-width: thin;
        }
        .newStyle6 {
            font-family: "Bahnschrift SemiCondensed";
            font-size: 15px;
        }
        .newStyle7 {
            font-family: "Bahnschrift SemiBold SemiConden";
            font-size: 15px;
        }
        .newStyle8 {
            font-family: "Bahnschrift SemiBold SemiConden";
            font-size: 15px;
        }
        .newStyle9 {
            font-family: "Javanese Text";
        }
        .newStyle10 {
            background-color: #FF00FF;
        }
        .newStyle11 {
            background-color: #FFFFFF;
        }
        .newStyle12 {
            background-image: url('download.jfif');
            background-repeat: inherit;
            background-attachment: scroll;
            background-position: center center;
            width: auto;
        }
        .newStyle13 {
            background-image: url('Zz1kNmFkYmFmNzhlNGIxMWViYTU1ZDFmYjg0ZWI5MTc4Zg==.jpg');
            background-repeat: no-repeat;
            background-attachment: inherit;
            background-position: center;
        }
        a:active {
            background-image: url('images.jfif');
        }
        .newStyle14 {
            background-image: url('images (1).jfif');
            background-repeat: no-repeat;
        }
        .newStyle15 {
            background-image: url('images (1).jfif');
            background-position: center center;
            background-attachment: scroll;
            border-style: inherit;
            border-width: thin;
            padding: inherit;
            margin: inherit;
            overflow: auto;
            float: none;
            cursor: auto;
        }
        .auto-style1 {
            width: 1286px;
            margin-left: 5px;
        }
        #form1 {
            width: 1023px;
            margin-left: 29px;
        }
    </style>
</head>
<body>
    <h1 class="newStyle1" style="text-align: center; width: 1288px; margin-left: 0px;">ASP.Net Calc Application</h1>

            <hr class="auto-style1" />

    <form id="form1" runat="server">
        <div>
            <p>
                <span class="newStyle6">Enter the First Value:</span> 
                <asp:TextBox runat="server" ID="txtFirstNo" CssClass="newStyle2" Height="16px" Width="103px" />
            </p>
            <p>
                <span class="newStyle7">Select the Option:</span> 
                <asp:DropDownList runat="server" ID="dpList" CssClass="newStyle3" Height="36px" Width="53px">
                    <asp:ListItem Text="Add" />
                    <asp:ListItem Text="Subtract" />
                    <asp:ListItem Text="Multiply" />
                    <asp:ListItem Text="Divide" />
                </asp:DropDownList>
            </p>
            <p>
                <span class="newStyle8">Enter the Second Value:</span> 
                <asp:TextBox runat="server" ID="txtSecondNo" CssClass="newStyle4" />
            </p>
            <p>
                <asp:Button Text="Get Result" runat="server" ID="btnResult" OnClick="btnResult_Click" CssClass="newStyle5" />
            </p>
            <p>
               <asp:Label Text="The Result: " ID="lblDisplay" runat="server" CssClass="newStyle9" />
            </p>
        </div>
    </form>

</body>
</html>

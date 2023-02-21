<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DataComponent.ascx.cs" Inherits="WebApplication1.Controls.DataComponent" %>

<div>
    <asp:Repeater ID="rpData" runat="server">
        <HeaderTemplate>
            <table border="1" width="100%">
                <thead>
                    <tr>
                        <th>EmpId</th>
                        <th>EmpName</th>
                        <th>EmpAddress</th>
                        <th>EmpSalary</th>
                    </tr>
                </thead>
           
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("EmpId") %></td>
                <td><%#Eval("EmpName") %></td>
                <td><%#Eval("EmpAddress") %></td>
                <td><%#Eval("EmpSalary") %></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</div>

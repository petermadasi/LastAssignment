<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Last_Assignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .newStyle1 {
            border-collapse:collapse;
            border-style: solid;
            border-width: thick;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">

        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <br />
        
        <br />
        
        <asp:DataList ID="DataList1" runat="server"  Width="886px" CssClass="newStyle1">
            <ItemTemplate>
             <table border="1">
                 <tr>
                      <td style="width:200px;"><%#Eval("Id") %> </td>
                      <td style="width:200px;"><%#Eval("Name") %> </td>
                      <td style="width:200px;"><asp:Image ID="Image1" runat ="server" ImageUrl='<%#Eval("Pic") %>' Width="50px" Height="50px"/></td>
                      <td style="width:200px;"><%#Eval("Price") %> </td>
                      <td style="width:200px;"><%#Eval("Count") %> </td>
                      <td ><%#Eval("TotalPrice") %> </td>
                     <td style="width:200px;"><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CommandArgument='<%#Eval("Id") %>'>Delete the row here</asp:LinkButton>
                      </td>
                      
                </tr>
            </table>

         </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click to change" />
        <br />

        <br />

    </form>
</body>
</html>
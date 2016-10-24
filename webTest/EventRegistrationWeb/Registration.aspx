<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="EventRegistrationWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="labelEvent" runat="server" Text="Event:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dropDownListEvent" runat="server">
                        <asp:ListItem>Introduction to ASP.NET</asp:ListItem>
                        <asp:ListItem>Introduction to Windows Azure</asp:ListItem>
                        <asp:ListItem>Take off to .NET 4.0</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelFirstname" runat="server" Text="First Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelLastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelResult" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="buttonSubmit" runat="server" OnClick="buttonSubmit_Click" PostBackUrl="~/ResultsPage.aspx" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

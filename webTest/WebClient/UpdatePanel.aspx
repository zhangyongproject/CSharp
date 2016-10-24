<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePanel.aspx.cs" Inherits="WebApplication1.UpdatePanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManagerl" runat="server">
            </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="AJAX  postback"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button_Click" Text="Button" />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text=".Net postback"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button_Click" />
        </p>
    </form>
</body>
</html>

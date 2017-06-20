<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="QA1.aspx.vb" Inherits="QA1_WebVer.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Label"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="ans1t" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="ans1b" runat="server" Text="これを選ぶ" Width="200px" />
            <br />
            <asp:Label ID="ans2t" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="ans2b" runat="server" Text="これを選ぶ" Width="200px" />
            <br />
            <asp:Label ID="ans3t" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="ans3b" runat="server" Text="これを選ぶ" Width="200px" />
        </center>
    </form>
</body>
</html>

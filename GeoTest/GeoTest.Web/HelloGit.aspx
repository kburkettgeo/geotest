<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloGit.aspx.cs" Inherits="GeoTest.Web.HelloGit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hello Git!</h1>
        <asp:Repeater runat="server" ID="rptMessages">
            <ItemTemplate>
                <asp:Literal runat="server" ID="litMessage"></asp:Literal><br/>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>

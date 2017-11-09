<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Primer Numero"></asp:Label>
            <asp:TextBox ID="txtn1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Segundo Numero"></asp:Label>
            <asp:TextBox ID="txtn2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnsuma" runat="server" OnClick="suma" Text="Suma" />
        <asp:Button ID="btnresta" runat="server"  OnClick="resta" Text="Resta" />
        <asp:Button ID="btmulti" runat="server" OnClick="multi" Text="Multiplicacion" />
        <asp:Button ID="btndiv" runat="server" OnClick="div" Text="Division" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SumaPropia" />
        <p>
            <asp:Label ID="lblresultado" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

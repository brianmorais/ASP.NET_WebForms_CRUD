<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autenticar.aspx.cs" Inherits="ExemploCrud.UI.Autenticar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            USUÁRIO: <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br/>
            SENHA: <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
            <br/>
            <asp:Button ID="btnAutenticar" runat="server" Text="Autenticar" OnClick="btnAutenticar_Click" />
        </div>
    </form>
</body>
</html>

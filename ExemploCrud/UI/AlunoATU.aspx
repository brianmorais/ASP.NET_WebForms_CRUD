<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlunoATU.aspx.cs" Inherits="ExemploCrud.UI.AlunoATU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Aluno - Atualizar</h1>
            <a href="../default.aspx">Página inicial</a>
            <hr />
            RA:<asp:TextBox ID="txtRa" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            CPF:<asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAtualizar" style="width:142px" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click" />
        </div>
    </form>
</body>
</html>

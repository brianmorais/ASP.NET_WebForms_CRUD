<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlunoCAD.aspx.cs" Inherits="ExemploCrud.UI.AlunoCAD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style ="text-align: center">Cadastrar - Aluno</h1>
            <br/>
            <a href ="../default.aspx">Pagina inicial</a>
            <hr />
            Nome:
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br/>
            CPF:
            <asp:TextBox ID="txtCpf" runat="server" style="margin-left: 8px"></asp:TextBox>
            <br/>
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" Width="95px" OnClick="btnCadastrar_Click" />
            <br/>
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

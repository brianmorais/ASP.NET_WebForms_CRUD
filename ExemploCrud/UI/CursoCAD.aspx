<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CursoCAD.aspx.cs" Inherits="ExemploCrud.UI.CursoCAD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Curso - Cadastro</h1>
            <a href ="../default.aspx">Pagina inicial</a>
            <hr />
            Descrição:
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
            Periodo:
            <asp:TextBox ID="txtPeriodo" runat="server" style="margin-left: 12px"></asp:TextBox>
            <br />
            Coordenador:<asp:DropDownList ID="cmbCoordenador" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" Width="95px" />
            <br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CursoATU.aspx.cs" Inherits="ExemploCrud.UI.CursoATU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style ="text-align: center">Curso - Atualização</h1>
            <a href ="../default.aspx">Pagina Inicial</a>
            <hr/>
            Id:<asp:TextBox ID="txtId" runat="server" ReadOnly="True"></asp:TextBox>
            <br/>
            Descrição:<asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
            Periodo:<asp:TextBox ID="txtPeriodo" runat="server"></asp:TextBox>
            <br />
            Coordenador:
            <asp:DropDownList ID="cmdCoordenador" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnAtualizar" style="width:142px" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click" />
        </div>
    </form>
</body>
</html>

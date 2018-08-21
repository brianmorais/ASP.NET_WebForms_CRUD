<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ExemploCrud._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href ="http://www.google.com.br">Exemplo Link</a>
            <br />
            <br/>
            <asp:Button ID="btnExemploLink" runat="server" Text="Exemplo Link" OnClick="btnExemploLink_Click" />
            <br />
            <br />

            <hr/>
            <asp:Button ID="btnCadastrarCurso" runat="server" Text="Cadastrar Curso" OnClick="btnCadastrar_Click" />
            &nbsp;
            <asp:Button ID="btnConsultarCurso" runat="server" Text="Consultar Curso" OnClick="btnConsultar_Click" />
            <br />
            <br />
            <asp:Button ID="btnCadastrarAluno" runat="server" OnClick="btnCadastrarAluno_Click" Text="Cadastrar Aluno" />
            <asp:Button ID="btnConsultarAluno" runat="server" OnClick="btnConsultarAluno_Click" style="margin-left: 14px" Text="Consultar Aluno" />
        </div>
    </form>
</body>
</html>

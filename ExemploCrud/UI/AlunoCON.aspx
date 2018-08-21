<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlunoCON.aspx.cs" Inherits="ExemploCrud.UI.AlunoCON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style ="text-align: center">Consultar - Aluno</h1>
            <br/>
            <a href ="../default.aspx">Pagina Inicial</a>
            <hr/>
            Filtrar por Descrição:
            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtro" OnClick="btnFiltrar_Click" />
            <br/>
            <asp:GridView ID="gvResultado" runat="server" OnRowCommand="gvResultado_RowCommand">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnExcluir" runat="server" CausesValidation="false" CommandArgument='<% #Eval("RA") %>' CommandName="cmdExcluir" OnClientClick="return confirm('Deseja realmente excluir?')" Text="Excluir" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnAtualizar" runat="server" CausesValidation="false" CommandArgument='<% #Eval("RA") %>' CommandName ="cmdAtualizar" Text="Atualizar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    Nenhum Regístro
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CursoCON.aspx.cs" Inherits="ExemploCrud.UI.CursoCON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style ="text-align: center">Curso - Consultar</h1>
            <a href ="../default.aspx">Pagina Inicial</a>
            <hr/>
            <br />
            Filtrar por Descrição:
            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
            <br />
            <br/>
            <asp:GridView ID="gvResultado" runat="server" OnRowCommand="gvResultado_RowCommand">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnExcluir" runat="server" CausesValidation="false" CommandName="cmdExcluir" CommandArgument='<% #Eval("Id") %>' OnClientClick="return confirm('Deseja realmente excluir?')" Text="Excluir" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnAtualizar" runat="server" CausesValidation="false" CommandName="cmdAtualizar" CommandArgument='<% #Eval("Id") %>' Text="Atualizar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    Nenhum curso cadastrado.
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

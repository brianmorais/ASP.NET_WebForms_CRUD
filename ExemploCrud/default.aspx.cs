using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCrud
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UsuarioLogado"] != null)
            {
                lblUsuario.Text = "Usuário logado: " + Session["UsuarioLogado"].ToString();
            }
            else
            {
                Response.Redirect("UI/Autenticar.aspx");
            }
        }

        protected void btnExemploLink_Click(object sender, EventArgs e)
        {
            //Redirecionar página
            Response.Redirect("http://www.google.com.br");
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Redirecionar para páginas internas
            Server.Transfer("UI/CursoCAD.aspx");
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Server.Transfer("UI/CursoCON.aspx");
        }

        protected void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            Server.Transfer("UI/AlunoCAD.aspx");
        }

        protected void btnConsultarAluno_Click(object sender, EventArgs e)
        {
            Server.Transfer("UI/AlunoCON.aspx");
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Response.Redirect("UI/Autenticar.aspx");
        }
    }
}
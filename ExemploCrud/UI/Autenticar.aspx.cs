using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCrud.UI
{
    public partial class Autenticar : System.Web.UI.Page
    {
        BLL.Login login = new BLL.Login();
        DAL.LoginDAL loginDAL = new DAL.LoginDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();
        }

        protected void btnAutenticar_Click(object sender, EventArgs e)
        {
            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;

            if (loginDAL.Autenticar(login))
            {
                Session.Add("UsuarioLogado", login.Usuario);
                Response.Redirect("~/default.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuáro ou senha inválidos')</script>");
            }
        }
    }
}
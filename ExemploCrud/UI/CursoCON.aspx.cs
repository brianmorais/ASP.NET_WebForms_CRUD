using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCrud.UI
{
    public partial class CursoCON : System.Web.UI.Page
    {
        BLL.Curso curso = new BLL.Curso();
        DAL.CursoDAL cursoDAL = new DAL.CursoDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvResultado.DataSource = cursoDAL.Consultar();
                gvResultado.DataBind();
            }

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            curso.Descricao = txtFiltro.Text;
            gvResultado.DataSource = cursoDAL.Consultar(curso);
            gvResultado.DataBind();
        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            curso.Id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "cmdExcluir")
            {
                cursoDAL.Excluir(curso);
                Response.Write("<script>alert('Curso Id: " + curso.Id + " excluido')</script>");
                btnFiltrar_Click(null, null);
            }
            else if (e.CommandName == "cmdAtualizar")
            {
                //Response.Write("<script>alert('Acionado')</script>");
                Response.Redirect("CursoATU.aspx?cod=" + curso.Id);
            }

        }
    }
}
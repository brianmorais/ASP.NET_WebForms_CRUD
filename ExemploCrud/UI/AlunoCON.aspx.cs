using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCrud.UI
{
    public partial class AlunoCON : System.Web.UI.Page
    {

        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();
        BLL.Aluno aluno = new BLL.Aluno();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                gvResultado.DataSource = alunoDAL.Consultar();
                gvResultado.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtFiltro.Text;
            gvResultado.DataSource = alunoDAL.Consultar(aluno);
            gvResultado.DataBind();
        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            aluno.Ra = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "cmdExcluir")
            {
                alunoDAL.Excluir(aluno);
                Response.Write("<script>alert('Aluno Ra: " + aluno.Ra + " excluido')</script>");
                btnFiltrar_Click(null, null);
            }
            else
            {
                if (e.CommandName == "cmdAtualizar")
                {
                    Response.Redirect("AlunoATU.aspx?cod=" + aluno.Ra);
                }
            }
        }
    }
}
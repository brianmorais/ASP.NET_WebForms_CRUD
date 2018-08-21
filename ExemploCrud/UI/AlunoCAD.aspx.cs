using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCrud.UI
{
    public partial class AlunoCAD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UsuarioLogado"] == null)
            {
                Response.Redirect("Autenticar.aspx");
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Aluno aluno = new BLL.Aluno();
                aluno.Nome = txtNome.Text;
                aluno.Cpf = txtCpf.Text;

                DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();

                alunoDAL.Cadastrar(aluno);

                lblMsg.Text = "Aluno cadastrado";
                txtCpf.Text = "";
                txtNome.Text = "";
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCrud.UI
{
    public partial class CursoCAD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.CoordenadorDAL coordenadorDAL = new DAL.CoordenadorDAL();
                cmbCoordenador.DataSource = coordenadorDAL.Consultar();
                cmbCoordenador.DataTextField = "Nome";
                cmbCoordenador.DataValueField = "Id";
                cmbCoordenador.DataBind();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Curso curso = new BLL.Curso();
                curso.Descricao = txtDescricao.Text;
                curso.Periodo = txtPeriodo.Text;
                curso.IdCoordenador = Convert.ToInt32(cmbCoordenador.SelectedValue);

                DAL.CursoDAL cursoDAL = new DAL.CursoDAL();

                cursoDAL.Cadastrar(curso);

                lblMsg.Text = "Curso cadastrado";
                txtDescricao.Text = "";
                txtPeriodo.Text = "";
                cmbCoordenador.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
            
        }
    }
}
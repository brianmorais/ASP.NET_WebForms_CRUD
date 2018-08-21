using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCrud.UI
{
    public partial class CursoATU : System.Web.UI.Page
    {
        BLL.Curso curso = new BLL.Curso();
        DAL.CursoDAL cursoDAL = new DAL.CursoDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            int idRecibido = 0;

            btnAtualizar.Enabled = false;
            if (!IsPostBack)
            {
                //Validar se está recebendo a variável cod na URL
                if (Request.QueryString["cod"] != null)
                {
                    //Validar se a variável veio com o valor preenchido
                    if (Request.QueryString["cod"].ToString() != "")
                    {
                        int.TryParse(Request.QueryString["cod"].ToString(), out idRecibido);
                        curso.Id = idRecibido;
                        curso = cursoDAL.Selecionar(curso);
                        if (curso.Id != 0)
                        {
                            txtId.Text = curso.Id.ToString();
                            txtDescricao.Text = curso.Descricao;
                            txtPeriodo.Text = curso.Periodo;

                            btnAtualizar.Enabled = true;
                        }
                        else
                        {
                            Response.Write("<script>alert('Curso não localizado')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Id de curso vazio')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Id de curso não recebido')</script>");
                }
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                curso.Id = Convert.ToInt32(txtId.Text);
                curso.Periodo = txtPeriodo.Text;
                curso.Descricao = txtDescricao.Text;

                cursoDAL.Atualizar(curso);

                txtDescricao.Text = "";
                txtId.Text = "";
                txtPeriodo.Text = "";

                Response.Write("<script>alert('Atualizado')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Erro')</script>");
                Response.Write("<div>" + ex.Message + "</div>");
            }
            
        }
    }
}
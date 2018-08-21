using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCrud.UI
{
    public partial class AlunoATU : System.Web.UI.Page
    {
        BLL.Aluno aluno = new BLL.Aluno();
        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            int raRecibido = 0;

            btnAtualizar.Enabled = false;
            if (!IsPostBack)
            {
                //Validar se está recebendo a variável cod na URL
                if (Request.QueryString["cod"] != null)
                {
                    //Validar se a variável veio com o valor preenchido
                    if (Request.QueryString["cod"].ToString() != "")
                    {
                        int.TryParse(Request.QueryString["cod"].ToString(), out raRecibido);
                        aluno.Ra = raRecibido;
                        aluno = alunoDAL.Selecionar(aluno);
                        if (aluno.Ra != 0)
                        {
                            txtRa.Text = aluno.Ra.ToString();
                            txtNome.Text = aluno.Nome;
                            txtCpf.Text = aluno.Cpf;

                            btnAtualizar.Enabled = true;
                        }
                        else
                        {
                            Response.Write("<script>alert('RA não localizado')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('RA de aluno vazio')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('RA de aluno não recebido')</script>");
                }
            }

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                aluno.Ra = Convert.ToInt32(txtRa.Text);
                aluno.Nome = txtNome.Text;
                aluno.Cpf = txtCpf.Text;

                alunoDAL.Atualizar(aluno);

                txtRa.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";

                Response.Write("<script>alert('Atualizado')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro')</script>");
                Response.Write("<div>" + ex.Message + "</div>");
            }
        }
    }
}
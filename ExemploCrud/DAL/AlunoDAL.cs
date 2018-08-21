using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ExemploCrud.DAL
{
    public class AlunoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Aluno a)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Aluno(
                                    Nome,
                                    CPF)
                                VALUES(@nome,@cpf)";

            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@cpf", a.Cpf);

            cmd.ExecuteNonQuery();

            con.Desconectar();
        }

        public DataTable Consultar()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    RA,
                                    Nome,
                                    CPF
                                FROM
                                    Aluno";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Aluno a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    Aluno
                                WHERE
                                    RA = @ra";
            cmd.Parameters.AddWithValue("@ra", a.Ra);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Consultar(BLL.Aluno a)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    RA,
                                    Nome,
                                    CPF
                                FROM
                                    Aluno
                                WHERE
                                    Nome like @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + a.Nome + "%");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public void Atualizar(BLL.Aluno a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE
                                    Aluno
                                SET
                                    Nome = @nome,
                                    CPF = @cpf                                    
                                WHERE
                                    RA = @ra";
            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@cpf", a.Cpf);
            cmd.Parameters.AddWithValue("@ra", a.Ra);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Aluno Selecionar(BLL.Aluno a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    RA,
                                    Nome,
                                    CPF
                                FROM
                                    Aluno
                                WHERE 
                                    RA = @ra";
            cmd.Parameters.AddWithValue("@ra", a.Ra);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                a.Ra = Convert.ToInt32(dr["RA"]);
                a.Nome = dr["Nome"].ToString();
                a.Cpf = dr["CPF"].ToString();
                dr.Close();
            }
            else
            {
                a.Ra = 0;
            }
            con.Desconectar();

            return a;
        }
    }
}
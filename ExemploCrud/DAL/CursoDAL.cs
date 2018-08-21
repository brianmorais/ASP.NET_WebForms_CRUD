using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ExemploCrud.DAL
{
    public class CursoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Curso c)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Curso(
                                    Descricao,
                                    Periodo,
                                    IdCoordenador)
                                VALUES(@descricao, @periodo, @idCoordenador)";
            
            cmd.Parameters.AddWithValue("@descricao", c.Descricao);
            cmd.Parameters.AddWithValue("@periodo", c.Periodo);
            cmd.Parameters.AddWithValue("@idCoordenador", c.IdCoordenador);
            cmd.ExecuteNonQuery();

            con.Desconectar();
        }

        public DataTable Consultar()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Curso.Id,
                                    Curso.Descricao,
                                    Curso.Periodo,
                                    --Curso.IdCoordenador,
                                    Coordenador.Nome
                                FROM
                                    Curso
                                INNER JOIN 
                                    Coordenador
                                ON
                                    Curso.IdCoordenador = Coordenador.Id";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Curso c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    Curso
                                WHERE
                                    Id = @id";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Consultar(BLL.Curso c)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Curso.Id,
                                    Curso.Descricao,
                                    Curso.Periodo,
                                    --Curso.IdCoordenador,
                                    Coordenador.Nome
                                FROM
                                    Curso
                                INNER JOIN 
                                    Coordenador
                                ON
                                    Curso.IdCoordenador = Coordenador.Id
                                WHERE
                                    Descricao like @descricao";
            cmd.Parameters.AddWithValue("@descricao", "%" + c.Descricao + "%");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public void Atualizar(BLL.Curso c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE
                                    Curso
                                SET
                                    Descricao = @descricao,
                                    Periodo = @periodo,
                                    IdCoordenador = @idCoordenador
                                WHERE
                                    Id = @id";
            cmd.Parameters.AddWithValue("@descricao", c.Descricao);
            cmd.Parameters.AddWithValue("@idCoordenador", c.IdCoordenador);
            cmd.Parameters.AddWithValue("@periodo", c.Periodo);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Curso Selecionar(BLL.Curso c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Id,
                                    Descricao,
                                    Periodo,
                                    IdCoordenador
                                FROM
                                    Curso
                                WHERE 
                                    Id = @id";
            cmd.Parameters.AddWithValue("@id", c.Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                c.Id = Convert.ToInt32(dr["Id"]);
                c.Descricao = dr["Descricao"].ToString();
                c.Periodo = dr["Periodo"].ToString();
                c.IdCoordenador = Convert.ToInt32(dr["IdCoordenador"]);
                dr.Close();
            }
            else
            {
                c.Id = 0;
            }
            con.Desconectar();

            return c;
        }
    }
}
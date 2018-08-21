using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ExemploCrud.DAL
{
    public class CoordenadorDAL
    {
        Conexao con = new Conexao();

        public DataTable Consultar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id, Nome
                                FROM Coordenador";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace ExemploCrud.DAL
{
    public class Conexao
    {
        SqlConnection con;


        public Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"DATA SOURCE = (LOCAL)\SQLEXPRESS;
                                   INITIAL CATALOG = BDCrud;
                                   INTEGRATED SECURITY = TRUE";
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
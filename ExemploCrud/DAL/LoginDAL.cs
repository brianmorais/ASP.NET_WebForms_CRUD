using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ExemploCrud.DAL
{
    public class LoginDAL
    {
        Conexao con = new Conexao();

        public bool Autenticar(BLL.Login l)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT USUARIO, SENHA 
                                FROM TBLogin
                                WHERE USUARIO = @usuario 
                                AND SENHA = @senha";
            cmd.Parameters.AddWithValue("@usuario", l.Usuario);
            cmd.Parameters.AddWithValue("@senha", l.Senha);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                con.Desconectar();
                return true;
            }
            else
            {
                con.Desconectar();
                return false;
            }
        }
    }
}
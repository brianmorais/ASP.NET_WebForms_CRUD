using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploCrud.BLL
{
    public class Login
    {
        private string _usuario;
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploCrud.BLL
{
    public class Aluno
    {
        private int _ra;
        private string _nome;
        private string _cpf;

        public int Ra
        {
            get
            {
                return _ra;
            }
            set
            {
                _ra = value;
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
    }
}
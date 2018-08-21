using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploCrud.BLL
{
    public class Curso
    {
        private int _id;
        private string _descricao;
        private string _periodo;
        private int _idCoordenador;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                _descricao = value;
            }
        }
        public string Periodo
        {
            get
            {
                return _periodo;
            }
            set
            {
                _periodo = value;
            }
        }
        public int IdCoordenador
        {
            get
            {
                return _idCoordenador;
            }
            set
            {
                _idCoordenador = value;
            }
        }



    }
}
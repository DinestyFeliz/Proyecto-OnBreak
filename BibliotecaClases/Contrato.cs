using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class Contrato
    {
        private string _numeroContrato;
        private DateTime _creacion;
        private DateTime _termino;
        private DateTime _horaInicio;
        private DateTime _horaTermino;
        private string _direccion;
        public Boolean _vigente { get; set; }


        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public DateTime Termino
        {
            get { return _horaTermino; }
            set { _horaTermino = value; }
        }


        public DateTime Inicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }


        public DateTime Finalizado
        {
            get { return _termino; }
            set { _termino = value; }
        }



        public DateTime Creacion
        {
            get { return _creacion; }
            set { _creacion = value; }
        }


        public string NumeroContrato
        {
            get { return _numeroContrato; }
            set { _numeroContrato = value; }
        }

    }
}

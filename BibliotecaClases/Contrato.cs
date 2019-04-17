using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Contrato
    {
        private string _numeroContrato { get; set; }
        private DateTime _creacion { get; set; }
        private DateTime _termino { get; set; }
        private string _horaInicio { get; set; }
        private string _horaTermino { get; set; }
        private string _direccion { get; set; }
        //public string _vigente { get; set; }
        public string _rutCliente { get; set; }
        //public string _idEvento { get; set; }


        public DateTime Termino
        {
            get { return _termino; }
            set { _termino = value; }
        }

        public DateTime Creacion
        {
            get { return _creacion; }
            set { _creacion = value; }
        }

        //public string Vigente
        //{
        //    get { return _vigente; }
        //    set { _vigente = value; }
        //}

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public string Fin
        {
            get { return _horaTermino; }
            set { _horaTermino = value; }
        }


        public string Inicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }

        public string NumeroContrato
        {
            get { return _numeroContrato; }
            set { _numeroContrato = value; }
        }


        public String Rut
        {
            get { return _rutCliente; }
            set { _rutCliente = value; }
        }


        public Contrato()
        {

        }

    }
}
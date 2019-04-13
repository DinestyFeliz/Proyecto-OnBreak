using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum ActividadEmpresa
    {
        Agropecuaria, Mineria, Manufactura, Comercio, Hoteleria, Alimentos, Transporte, Servicios
    }

    public enum TipoEmpresa
    {
        Spa, EIRL, Limitada, Sociedad_Anonima
    }

    class Cliente
    {
        private string _rut;
        private string _razonSocial;
        private string _nombreContrato;
        private string _mallContacto;
        private string _direccion;
        private int _telefono;
        public ActividadEmpresa Actividad { get; set; }
        public TipoEmpresa Tipo { get; set; }

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }


        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public string MallContacto
        {
            get { return _mallContacto; }
            set { _mallContacto = value; }
        }


        public string NombreContrato
        {
            get { return _nombreContrato; }
            set { _nombreContrato = value; }
        }


        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }


        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public Cliente()
        {

        }

        public Cliente(string rut, string razonSocial, string nombreContrato, string mallContacto, string direccion, int telefono,
            ActividadEmpresa actividad, TipoEmpresa tipo)
        {
            Rut = rut; RazonSocial = razonSocial; NombreContrato = nombreContrato; MallContacto = mallContacto; Direccion = direccion;
            Telefono = telefono; Actividad = actividad; Tipo = tipo;
        }

    }
}

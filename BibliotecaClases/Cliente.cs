using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class Cliente
    {
        private string _rut;
        private string _razonSocial;
        private string _nombreContrato;
        private string _mallContacto;
        private string _direccion;
        private int _telefono;

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

    }
}

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

    public class Cliente
    {
        private string _rut;
        private string _razonSocial;
        private string _nombreContrato;
        private string _mailContacto;
        private string _direccion;
        private int _telefono;
        public ActividadEmpresa Actividad { get; set; }
        public TipoEmpresa Tipo { get; set; }

        public int Telefono
        {
            get { return _telefono; }
            set {

                if (value != 0)
                {
                    _telefono = value;
                }
                else
                {
                    throw new ArgumentException("Telefono vacio");
                }

            }
        }


        public string Direccion
        {
            get { return _direccion; }
            set {

                if (value != null)
                {
                    _direccion = value;
                }
                else
                {
                    throw new ArgumentException("Direccion vacio");
                }

            }
        }


        public string MailContacto
        {
            get { return _mailContacto; }
            set {

                if (value != null)
                {
                    _mailContacto = value;
                }
                else
                {
                    throw new ArgumentException("Mail del contacto vacio");
                }

            }
        }


        public string NombreContrato
        {
            get { return _nombreContrato; }
            set
            {
                if (value != null)
                {
                    _nombreContrato = value;
                }
                else
                {
                    throw new ArgumentException("Nombre del contacto vacio");
                }
            }
        }


        public string RazonSocial
        {
            get { return _razonSocial; }
            set {

                if (value != null)
                {
                    _razonSocial = value;
                }
                else
                {
                    throw new ArgumentException("Razon social vacio");
                }

            }
        }


        public string Rut
        {
            get { return _rut; }
            set
            {
                if (value != null)
                {
                    _rut = value;
                }
                else
                {
                    throw new ArgumentException("Rut vacio");
                }
            }
        }

        public Cliente()
        {

        }

        public Cliente(string rut, string razonSocial, string nombreContrato, string mailContacto, string direccion, int telefono,
            ActividadEmpresa actividad, TipoEmpresa tipo)
        {
            Rut = rut; RazonSocial = razonSocial; NombreContrato = nombreContrato; MailContacto = mailContacto; Direccion = direccion;
            Telefono = telefono; Actividad = actividad; Tipo = tipo;
        }

    }
}
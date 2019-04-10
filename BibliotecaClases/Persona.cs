using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum TipoSexo
    {
        Masculino, Femenino
    }
    public class Persona
    {
        private String _rut;
        private String _nombre;
        private int _edad;
        private String _apellido;
        public TipoSexo Sexo { get; set; }

        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
            
        public string Rut
        {
            get
            {
                return _rut;
            }

            set
            {
                if (value.Length>=9 && value.Length<=10)
                {
                    _rut = value;
                }
                else
                {
                    throw new ArgumentException("rut entre 9 y 10");
                }
            }
        }

        public Persona()
        {

        }
        public Persona(string rut, string nombre, 
            int edad, string apellido, TipoSexo sexo)
        {
            Rut = rut;Nombre = nombre;Apellido = apellido;
            Edad = edad;Sexo = sexo;
        }
    }
}

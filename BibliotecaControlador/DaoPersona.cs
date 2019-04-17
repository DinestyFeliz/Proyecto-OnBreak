using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace BibliotecaControlador
{
    public class DaoPersona
    {
        private static List<Persona> personas;

        public DaoPersona()
        {
            if (personas==null)
            {
                personas = new List<Persona>();
            }
        }
        //metodos crud
        public bool Agregar(Persona per)
        {
            if (ExistePersona(per.Rut)==false)
            {
                personas.Add(per);return true;
            }
            return false;
        }

        private bool ExistePersona(string rut)
        {
            foreach (Persona item in personas)
            {
                if (item.Rut.Equals(rut))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Persona> Lista()
        {
            return personas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Evento
    {
        private string _id;
        private string _nombre;
        private int _valorBase;
        private int _perBase;
        private int _valorAgregado;
        private int _perExtra;

        public int PersonalExtra
        {
            get { return _perExtra; }
            set { _perExtra = value; }
        }


        public int ValorAgregado
        {
            get { return _valorAgregado; }
            set { _valorAgregado = value; }
        }


        public int PersonalBase
        {
            get { return _perBase; }
            set { _perBase = value; }
        }


        public int ValorBase
        {
            get { return _valorBase; }
            set { _valorBase = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string IdTipo
        {
            get { return _id; }
            set { _id = value; }
        }

        public Evento()
        {

        }

        public Evento(string id, string nombre, int valorBase, int perBase, int valorAgregado, int perExtra)
        {
            IdTipo = id; Nombre = nombre; ValorBase = valorBase; PersonalBase = perBase; ValorAgregado = valorAgregado; PersonalExtra = perExtra;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace BibliotecaControlador
{
    public class DaoEvento
    {
        private static List<Evento> eventos;

        public DaoEvento()
        {
            if (eventos == null)
            {
                eventos = new List<Evento>();
            }

        }
        //metodos (customer) C.R.U.D.
        public bool Crear(Evento eve)
        {
            if (ExisteEvento(int.Parse(eve.IdTipo)) == false)
            {
                eventos.Add(eve);
                return true;
            }
            return false;
        }

        private bool ExisteEvento(int idTipo)
        {
            foreach (Evento item in eventos)
            {
                if (item.IdTipo.Equals(idTipo))
                {
                    return true;
                }
            }
            return false;
        }

        //public List<Evento> Listar()
        //{
        //    return eventos;
        //}

        //public bool Eliminar(string numeroContrato)
        //{
        //    foreach (Contrato item in contratos)
        //   {
        //        if (item.NumeroContrato.Equals(numeroContrato))
        //        {
        //            contratos.Remove(item);
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public Evento Buscar(int idTipo)
        {
            foreach (Evento item in eventos)
            {
                if (item.IdTipo.Equals(idTipo))
                {
                    return item;
                }
            }
            return null;
        }

        //public bool Modificar(Contrato nuevo_con)
        //{
        //    foreach (Contrato item in contratos)
        //    {
        //        if (item.NumeroContrato.Equals(nuevo_con.NumeroContrato))
        //        {
        //            contratos.Remove(item);
        //            contratos.Add(nuevo_con);
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}

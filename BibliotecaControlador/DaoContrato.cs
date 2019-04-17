using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace BibliotecaControlador
{
    public class DaoContrato
    {
        private static List<Contrato> contratos;

        public DaoContrato()
        {
            if (contratos == null)
            {
                contratos = new List<Contrato>();
            }

        }
        //metodos (customer) C.R.U.D.
        public bool Crear(Contrato con)
        {
            if (ExisteContrato(con.NumeroContrato) == false)
            {
                contratos.Add(con);
                return true;
            }
            return false;
        }

        private bool ExisteContrato(string numeroContrato)
        {
            foreach (Contrato item in contratos)
            {
                if (item.NumeroContrato.Equals(numeroContrato))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Contrato> Listar()
        {
            return contratos;
        }

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

        public Contrato Buscar(string numeroContrato)
        {
            foreach (Contrato item in contratos)
            {
                if (item.NumeroContrato.Equals(numeroContrato))
                {
                    return item;
                }
            }
            return null;
        }

        public bool Modificar(Contrato nuevo_con)
        {
            foreach (Contrato item in contratos)
            {
                if (item.NumeroContrato.Equals(nuevo_con.NumeroContrato))
                {
                    contratos.Remove(item);
                    contratos.Add(nuevo_con);
                    return true;
                }
            }
            return false;
        }
    }
}

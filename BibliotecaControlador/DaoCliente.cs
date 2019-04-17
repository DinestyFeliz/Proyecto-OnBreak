using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace BibliotecaControlador
{
    public class DaoCliente
    {
        private static List<Cliente> clientes;

        public DaoCliente()
        {
            if (clientes == null)
            {
                clientes = new List<Cliente>();
            }

        }
        //metodos (customer) C.R.U.D.
        public bool Crear(Cliente cli)
        {
            if (ExisteRut(cli.Rut) == false)
            {
                clientes.Add(cli);
                return true;
            }
            return false;
        }

        private bool ExisteRut(string rut)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Rut.Equals(rut))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Cliente> Listar()
        {
            return clientes;
        }

        public bool Eliminar(string rut)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Rut.Equals(rut))
                {
                    clientes.Remove(item); return true;
                }
            }
            return false;
        }

        public Cliente Buscar(string rut)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Rut.Equals(rut))
                {
                    return item;
                }
            }
            return null;
        }

        public List<Cliente> FiltroRut(string rut)
        {
            List<Cliente> lp = clientes.Where(x => x.Rut.Equals(rut)).
                ToList();
            return lp;
        }

        public List<Cliente> FiltroEmpresa(TipoEmpresa tipo)
        {
            List<Cliente> lp = clientes.Where(x => x.Tipo.Equals(tipo)).
                ToList();
            return lp;
        }

        public List<Cliente> FiltroActividad(ActividadEmpresa actividad)
        {
            List<Cliente> lp = clientes.Where(x => x.Actividad.Equals(actividad)).
                ToList();
            return lp;
        }

        public bool Modificar(Cliente nueva_per)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Rut.Equals(nueva_per.Rut))
                {
                    clientes.Remove(item);
                    clientes.Add(nueva_per);
                    return true;
                }
            }
            return false;
        }
    }
}


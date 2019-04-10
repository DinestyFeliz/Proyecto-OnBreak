using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//entrada y salida

namespace BibliotecaControlador
{
    public class Logger
    {
        public static void Mensaje(String msg)
        {
            msg = DateTime.Now + " | " + msg + Environment.NewLine;
            File.AppendAllText(@"d:\logger.txt", msg);
        }
    }
}

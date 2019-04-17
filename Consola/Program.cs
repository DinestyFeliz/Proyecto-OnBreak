using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using para conexion con web service externo
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ws();
        }

        private static void ws()
        {
            //web service externo
            ClDatos datos;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://mindicador.cl/api/uf");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader stream_reader = new StreamReader(stream);
            var json = stream_reader.ReadToEnd();
            datos = JsonConvert.DeserializeObject<ClDatos>(json);

            Console.WriteLine("recupero");
            Console.WriteLine("version: "+datos.version);
            Console.WriteLine("autor: " + datos.autor);
            Console.ReadKey();
            string uf = "";
            foreach (Serie item in datos.serie)
            {
                uf = item.valor;
            }
            uf = uf.Replace('.', ',');
            Console.WriteLine("El valor de la uf es: " + uf);
            double valor_uf = double.Parse(uf);
            Console.WriteLine("valor UF ${0}", valor_uf);
            Console.ReadKey();
        }
    }
}

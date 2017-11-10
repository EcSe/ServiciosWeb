using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Demo01WS;

namespace WCFConsola1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* este viene a ser el addres
             ADDRESS. Definiremos la URL en la que expondremos 
             el servicio y le asignaremos un nombre. 
             En nuestro caso Calculadora*/
            Uri mirurl = new Uri("http://localhost:2189/Calculadora");

            /*el bindingBINDING. Especificaremos
             el protocolo de comunicación a nuestro servicio*/
            BasicHttpBinding elbinding = new BasicHttpBinding();

            /*CONTRACT. Especificaremos el contrato de operaciones 
             * expuesto por nuestro servicio*/
            ServiceHost elhost = new ServiceHost(typeof(Calculadora), mirurl);

            elhost.AddServiceEndpoint(typeof(ICalculadora), elbinding, "");
            elhost.Open();


            try
            {
                Console.WriteLine("Servicio alojado en" + mirurl.AbsoluteUri);
                Console.ReadLine();
            }
            finally
            {
                elhost.Close();
            }
        }
    }
}

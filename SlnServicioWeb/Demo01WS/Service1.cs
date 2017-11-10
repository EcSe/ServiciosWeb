using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Demo01WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public void DoWork()
        {
        }

        public string holaMundo(string nombre)
        {
            return "Hola Mundo" + nombre + "¡";
        }
    }

    public class Calculadora : ICalculadora
    {
        public int resta(int n1, int n2)
        {
            return n1 - n2;
        }

        public int suma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Demo01WS
{
    

    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        String holaMundo(String nombre);

    }

    [ServiceContract]
    public interface ICalculadora
    {
        [OperationContract]
        int suma(int n1, int n2);

        [OperationContract]
        int resta(int n1, int n2);
    }


}

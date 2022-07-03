using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IsrvEmpleado
    {
        [OperationContract]
        List<Empleado> ListarEmpleados();
        [OperationContract]
        Empleado ListarEmpleado(int Id);
        [OperationContract]
        List<Empleado> ListarEmpleadosNom(string nombre);
        [OperationContract]
        string NuevoEmpleado(Empleado emp);
        [OperationContract]
        string ModificarEmpleado(Empleado emp);
        [OperationContract]
        string EliminarEmpleado(int Id);
        [OperationContract]
        List<Empleado> ListarEmpleadoFechaNac(
                DateTime fechDesde, DateTime fechaHasta);

    }



}

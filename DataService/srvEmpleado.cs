using DataAccess;
using DataAccess.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class srvEmpleado : IsrvEmpleado
    {
        public List<Empleado> ListarEmpleados()
        {
            var emp = new dtoEmpleado();
            return emp.ListarEmpleados();
        }
        public Empleado ListarEmpleado(int Id)
        {
            var emp = new dtoEmpleado();
            return emp.ListarEmpleado(Id);
        }
        public List<Empleado> ListarEmpleadosNom(string nombre)
        {
            var emp = new dtoEmpleado();
            return emp.ListarEmpleados(nombre);
        }
        public string NuevoEmpleado(Empleado emp)
        {
            var empN = new dtoEmpleado();
            return empN.NuevoEmpleado(emp);
        }
        public string ModificarEmpleado(Empleado emp)
        {
            var empN = new dtoEmpleado();
            return empN.ModificarEmpleado(emp);
        }
        public string EliminarEmpleado(int Id)
        {
            var empN = new dtoEmpleado();
            return empN.EliminarEmpleado(Id);
        }
        public List<Empleado> ListarEmpleadoFechaNac(
                DateTime fechDesde, DateTime fechaHasta)
        {
            var empN = new dtoEmpleado();
            return empN.ListarEmpleadoFechaNac(fechDesde, fechaHasta);
        }
    }
}

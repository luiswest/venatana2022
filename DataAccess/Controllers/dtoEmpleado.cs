using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace DataAccess.Controllers
{
    public class dtoEmpleado
    {
        public List<Empleado> ListarEmpleados()
        {
            using (var ctx = new videoClubEntities1())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                ctx.Configuration.ProxyCreationEnabled = false;
                return ctx.Empleado.ToList();
            }
        }
        public Empleado ListarEmpleado(int Id)
        {
            using (var ctx = new videoClubEntities1())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                ctx.Configuration.ProxyCreationEnabled = false;
                var emp = (from e in ctx.Empleado
                           where e.Id.Equals(Id)
                           select e).FirstOrDefault();
                return emp;
            }
        }
        public List<Empleado> ListarEmpleadoFechaNac(
            DateTime fechDesde, DateTime fechaHasta)
        {
            using (var ctx = new videoClubEntities1())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                ctx.Configuration.ProxyCreationEnabled = false;
                var emp = (from e in ctx.Empleado
                           where e.FechaNac >= fechDesde &&
                                  e.FechaNac <= fechaHasta
                           select e).ToList();
                return emp;
            }
        }
        public List<Empleado> ListarEmpleados(string nombre)
        {
            using (var ctx = new videoClubEntities1())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                ctx.Configuration.ProxyCreationEnabled = false;
                var emp = (from e in ctx.Empleado
                           where e.Nombre.Contains(nombre)
                           select e).ToList();
                return emp;
            }
        }
        public string NuevoEmpleado(Empleado emp)
        {
            using (var ctx = new videoClubEntities1())
            {
                ObjectParameter output = new ObjectParameter("output", typeof(int));
                ctx.NuevoEmpleado(
                      emp.IdEmpleado,
                      emp.Nombre,
                      emp.Apellido1,
                      emp.Apellido2,
                      emp.Sexo,
                      emp.FechaNac,
                      emp.Telefono,
                      emp.Celular,
                      emp.Direccion,
                      emp.CorreoE,
                      emp.Estado,
                      output
                    );
                return output.Value.ToString();
            }
        }
        public string ModificarEmpleado(Empleado emp)
        {
            using (var ctx = new videoClubEntities1())
            {
                ObjectParameter output = new ObjectParameter("output", typeof(int));
                ctx.ModificarEmpleado(
                      emp.Id,
                      emp.Nombre,
                      emp.Apellido1,
                      emp.Apellido2,
                      emp.Sexo,
                      emp.FechaNac,
                      emp.Telefono,
                      emp.Celular,
                      emp.Direccion,
                      emp.CorreoE,
                      emp.Estado,
                      output
                    );
                return output.Value.ToString();
            }
        }
        public string EliminarEmpleado(int Id)
        {
            using (var ctx = new videoClubEntities1())
            {
                ObjectParameter output = new ObjectParameter("output", typeof(int));
                ctx.EliminarEmpleado(Id, output);
                return output.Value.ToString();
            }
        }
    }
}

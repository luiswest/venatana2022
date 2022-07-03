using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deskVideoClub
{
    public partial class Form1 : Form
    {
        private clienteVideoClub.IsrvEmpleadoClient cliente = new clienteVideoClub.IsrvEmpleadoClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarEmpleado();
        }
        private void cargar(List<clienteVideoClub.Empleado> bEmp)
        {
            var emp = (from em in bEmp
                       select new
                       {
                           Id = em.Id,
                           idempleado = em.IdEmpleado,
                           Nombre = em.Nombre,
                           Apellido1 = em.Apellido1,
                           Apellido2 = em.Apellido2,
                           Telefono = em.Telefono,
                           Celular = em.Celular,
                           Correo = em.CorreoE
                       });

            dataGridView1.DataSource = emp.ToList();
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            cargarPorCodigo(id);

        }
        private void cargarEmpleado()
        {
            List<clienteVideoClub.Empleado> bEmp = (cliente.ListarEmpleados()).ToList();
            cargar(bEmp);
        }
        private void cargarPorCodigo(int Id)
        {
            clienteVideoClub.Empleado bEmp = (cliente.ListarEmpleado(Id));
            txtIdEmpleado.Text = bEmp.IdEmpleado;
            txtNombre.Text = bEmp.Nombre;
            txtApellido1.Text = bEmp.Apellido1;
            txtApellido2.Text = bEmp.Apellido2;
            txtTelefono.Text = bEmp.Telefono;
            txtCelular.Text = bEmp.Celular;
            txtDireccion.Text = bEmp.Direccion;
            txtCorreo.Text = bEmp.CorreoE;
            dtpFechaNac.Value = bEmp.FechaNac;
            rbHombre.Checked = ( bEmp.Sexo == "M");
            rbMujer.Checked = ( bEmp.Sexo == "F");
            chkEstado.Checked = ( bEmp.Estado == "A");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            cargarPorCodigo(id);
        }
    }
}

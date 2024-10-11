using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PreExamen.Controller;

namespace PreExamen
{
    public partial class Form1 : Form
    {
        ControllerAlumno ca = new ControllerAlumno();

        public Form1()
        {
            InitializeComponent();
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            ca.EliminarAlumno(Convert.ToInt32(TBID.Text));
            MessageBox.Show("Alumno eliminado con exito");
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = Convert.ToString(TBNombre.Text);
            string Apellido = Convert.ToString(TBApellido.Text);
            string Fecha = Convert.ToString(TBFechaNac.Text);
            string Correo = Convert.ToString(TBCorreo.Text);

            ca.InsertarAlumno(Nombre, Apellido, Fecha, Correo);
            MessageBox.Show("Alumno agregado con exito");
        }

        private void BTActualizar_Click(object sender, EventArgs e)
        {
            string Nombre = Convert.ToString(TBNombre.Text);
            string Apellido = Convert.ToString(TBApellido.Text);
            string Fecha = Convert.ToString(TBFechaNac.Text);
            string Correo = Convert.ToString(TBCorreo.Text);
            int ID = Convert.ToInt32(TBID.Text);

            ca.ActualizarAlumno(ID, Nombre, Apellido, Fecha, Correo);
            MessageBox.Show("Alumno actualizado con exito");
        }

        private void BTMostrar_Click(object sender, EventArgs e)
        {
            DGVUni.DataSource = null;
            DGVUni.DataSource = ca.ObtenerAlumno();
        }
    }
}

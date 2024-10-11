using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PreExamen.Model.DSUniversidadTableAdapters;

namespace PreExamen.Controller
{
    class ControllerAlumno : IAlumno
    {
        Alumno al = new Alumno();
        List<Alumno> lalumno = new List<Alumno>();


        public bool ActualizarAlumno(int id, string nombre, string apellido, string fecha, string correo)
        {
            try
            {
                using (alumnosTableAdapter atu = new alumnosTableAdapter())
                {

                    atu.ActualizarAlumno(nombre, apellido, fecha, correo, id);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public bool EliminarAlumno(int id)
        {
            try
            {
                using (alumnosTableAdapter atu = new alumnosTableAdapter())
                {
                    atu.EliminarAlumno(id);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool InsertarAlumno(string nombre, string apellido, string fecha, string correo)
        {
            try
            {
                using (alumnosTableAdapter atu = new alumnosTableAdapter())
                {
                    atu.InsertarAlumno(nombre, apellido, fecha, correo);
                    return true;
                }

            }
            catch (Exception )
            {
                return false;
                throw;
            }
        }

        public List<Alumno> ObtenerAlumno()
        {
            using (alumnosTableAdapter atu = new alumnosTableAdapter())
            {
                var datos = atu.GetData();
                foreach (DataRow row in datos)
                {
                    al.AlumnoID = Convert.ToInt32(row["AlumnoID"]);
                    al.Nombre = Convert.ToString(row["Nombre"]);
                    al.Apellido = Convert.ToString(row["Apellido"]);
                    al.FechaNacimiento = Convert.ToString(row["FechaNacimiento"]);
                    al.Correo = Convert.ToString(row["Correo"]);

                    lalumno.Add(new Alumno(al.AlumnoID, al.Nombre, al.Apellido, al.FechaNacimiento, al.Correo));
                }
            }
            return lalumno;
        }
    }
}

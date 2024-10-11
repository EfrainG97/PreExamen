using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamen.Controller
{
    interface IAlumno
    {
        List<Alumno> ObtenerAlumno();

        bool InsertarAlumno(string nombre, string apellido, string fecha, string correo);
        bool ActualizarAlumno(int id, string nombre, string apellido, string fecha, string correo);
        bool EliminarAlumno(int id);

    }
}

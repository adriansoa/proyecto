using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Alumno : Persona
    {
       public String Promocion;
    
        public override string ToString()
        {
            return string.Format ("Nombre: {0} Nro Doc: {1} Telefono: {2}", this.nombre ,this.nro_documento , this.telefono);
        }

        public static List<Alumno> listadoAlumnos = new List<Alumno>();

        public static void AgregarAlumno(Alumno a)
        {
            listadoAlumnos.Add(a);
        }
        public static void EliminarAlumno(Alumno a)
        {
            listadoAlumnos.Remove(a);
        }
        public static List<Alumno> ObtenerCarnes()
        {
            return listadoAlumnos;
        }


    }
}

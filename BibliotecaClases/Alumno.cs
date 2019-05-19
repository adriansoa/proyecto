using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Alumno : Persona
    {
        public DateTime Fecha_Nacimiento {
             get { return Fecha_Nacimiento; }

            set {
                 String.Format("{0: dd/MM/yyyy}",Fecha_Nacimiento);
            }
        }



        //private String Promocion;
        
        public override string ToString()
        {
            return string.Format ("Nombre: {0} Nro Doc: {1} Telefono: {2}", this.nombre ,this.nro_documento , this.telefono);
        }

      

    

        public Alumno()
        {
     
        }

        //Firma de Metodo
        public void RegistrarAlumno()
        {   
        }


    }
}

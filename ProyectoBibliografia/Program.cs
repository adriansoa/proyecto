using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;



namespace ProyectoBibliografia
{
    public class Program
    {
        static void Main(string[] args)
        {

            Alumno Alu1 = new Alumno();

            Alu1.nombre = "Hernan";
            Alu1.apellido = "Leguizamon";
           // Alu1.Fecha_Nacimiento = 20/05/2019;


            Console.WriteLine("El alumno {0} {1} nació el {2}", Alu1.nombre,Alu1.apellido,Alu1.Fecha_Nacimiento);
            Console.ReadKey();

        }
    }
}

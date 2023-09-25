using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_3
{
    internal class Alumno
    {
        private int DNI { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string escuela { get; set; }


        public Alumno (int dni, string nombre, string apellido, string escuela)
        {
            this.nombre = nombre;
            this.DNI = dni;
            this.apellido = apellido;
            this.escuela = escuela; 
        }

        public int getDNI()
        {
            return DNI;
        }

    }
}

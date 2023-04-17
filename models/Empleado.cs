using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GestiónEstudiantesEmpleados.models;

namespace GestiónEstudiantesEmpleados.models
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public double SueldoBase { get; set; }
        public string Dni { get; set; }

        protected Empleado(string nombre, string apellidos, double sueldoBase, string dni)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            SueldoBase = sueldoBase;
            Dni = dni;
        }

        public abstract string Informacion();
    }

}

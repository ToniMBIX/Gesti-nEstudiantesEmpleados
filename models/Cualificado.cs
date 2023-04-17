using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónEstudiantesEmpleados.models
{
    public class Cualificado : Empleado
    {
        public string Titulacion { get; set; }
        public double Plus { get; set; }
        public string Departamento { get; set; }

        public Cualificado(string nombre, string apellidos, double sueldoBase, string dni, string titulacion, double plus, string departamento)
            : base(nombre, apellidos, sueldoBase, dni)
        {
            Titulacion = titulacion;
            Plus = plus;
            Departamento = departamento;
        }

        public override string Informacion()
        {
            return $"Titulación: {Titulacion}, Departamento: {Departamento}";
        }
    }
}

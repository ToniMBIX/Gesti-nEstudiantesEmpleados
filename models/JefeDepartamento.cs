using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónEstudiantesEmpleados.models
{
    public class JefeDepartamento : Cualificado
    {
        public int TotalTrabaCargo { get; set; }
        public string Proyectos { get; set; }
        public double PlusJefe { get; set; }

        public JefeDepartamento(string nombre, string apellidos, double sueldoBase, string dni, string titulacion, double plus, string departamento, int totalTrabaCargo, string proyectos, double plusJefe)
            : base(nombre, apellidos, sueldoBase, dni, titulacion, plus, departamento)
        {
            TotalTrabaCargo = totalTrabaCargo;
            Proyectos = proyectos;
            PlusJefe = plusJefe;
        }
    }
}

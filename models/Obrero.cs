using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónEstudiantesEmpleados.models
{
    public class Obrero : Empleado
    {
        public string DestinoTrabajo { get; set; }
        public int HorasExtra { get; set; }
        public double PrecioHE { get; set; }

        public Obrero(string nombre, string apellidos, double sueldoBase, string dni, string destinoTrabajo, int horasExtra, double precioHE)
            : base(nombre, apellidos, sueldoBase, dni)
        {
            DestinoTrabajo = destinoTrabajo;
            HorasExtra = horasExtra;
            PrecioHE = precioHE;
        }

        public override string Informacion()
        {
            return $"Destino: {DestinoTrabajo}, Precio Horas Extra: {PrecioHE}€";
        }
    }
}

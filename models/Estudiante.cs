using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónEstudiantesEmpleados.models
{
    internal interface Estudiante
    {
        List<double> Examenes(int cantidadNotas);
        string Universidad(string nombreUniversidad);
        double NotaMedia();
    }
}

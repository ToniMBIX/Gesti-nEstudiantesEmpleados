using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónEstudiantesEmpleados.models
{
    public class Becario : Empleado, Estudiante
    {
        public string Carrera { get; set; }
        public int Curso { get; set; }
        public string DepartamentoBecario { get; set; }
        public int CantidadNotas { get; set; }
        public string NombreUniversidad { get; set; }

        public Becario(string nombre, string apellidos, double sueldoBase, string dni, string carrera, int curso, string departamentoBecario, int cantidadNotas, string nombreUniversidad)
            : base(nombre, apellidos, sueldoBase, dni)
        {
            Carrera = carrera;
            Curso = curso;
            DepartamentoBecario = departamentoBecario;
            CantidadNotas = cantidadNotas;
            NombreUniversidad = nombreUniversidad;
        }

        public override string Informacion()
        {
            return $"Carrera: {Carrera}, Departamento: {DepartamentoBecario}";
        }

        public List<double> Examenes(int cantidadNotas)
        {
            List<double> notas = new List<double>();
            Random rnd = new Random();
            for (int i = 0; i < cantidadNotas; i++)
            {
                notas.Add(rnd.Next(0, 101) / 10.0);
            }
            return notas;
        }

        public string Universidad(string nombreUniversidad)
        {
            return $"Universidad: {nombreUniversidad}";
        }

        public double NotaMedia()
        {
            List<double> notas = Examenes(CantidadNotas);
            double suma = notas.Sum();
            double media = suma / notas.Count;
            return Math.Round(media, 1);
        }
    }
}

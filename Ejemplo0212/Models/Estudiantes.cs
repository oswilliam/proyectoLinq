using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo0212.Models
{
    public class Estudiantes
    {
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double Promedio { get; set; }
        public DateTime FechaRegistro { get; set; }


        public List<Estudiantes> Lista()
        {
            var estudiantes1 = new Estudiantes()
            {
                Carnet = 001,
                Nombre = "María",
                Materia = "Literatura",
                Promedio = 8.5,
                FechaRegistro = DateTime.Now
            };
            var estudiantes2 = new Estudiantes()
            {
                Carnet = 002,
                Nombre = "Juan",
                Materia = "Gestión de BD",
                Promedio = 3,
                FechaRegistro = DateTime.Now
            };
            var estudiantes3 = new Estudiantes()
            {
                Carnet = 003,
                Nombre = "Pedro",
                Materia = "Linq",
                Promedio = 8,
                FechaRegistro = DateTime.Now
            };
            var estudiantes4 = new Estudiantes()
            {
                Carnet = 004,
                Nombre = "Juan",
                Materia = "Matemática",
                Promedio = 7,
                FechaRegistro = DateTime.Now
            };
            return new List<Estudiantes>() { estudiantes1, estudiantes2, estudiantes3, estudiantes4 };
        }
    }
}
using EstructuraAvanzada23AM.Entities;
using EstructuraAvanzada23AM.Services;
using System;

namespace EstructuraAvanzada23AM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AlumnoServices servicio = new AlumnoServices();
            Alumno alumno1 = servicio.Agregar();
            servicio.Imprimir(alumno1);
            Console.WriteLine("La calificacion es  "+ alumno1.Promedio));
        }
    }
}

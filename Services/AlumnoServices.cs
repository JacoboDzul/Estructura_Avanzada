using EstructuraAvanzada23AM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraAvanzada23AM.Services
{
    public class AlumnoServices
    {
        public Alumno Agregar()
        {
            try
            {
                Alumno alumno = new Alumno()
                {
                    Nombre = "Jacobo",
                    FechaIngreso = DateTime.Now,
                    Grado = 5,
                    Promedio = 10
                };
                return alumno;
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error :(" + ex.Message);
            }
        }
        public void Imprimir(Alumno request)
        {
           
            try
            {
                Console.WriteLine("El nombre es "+request.Nombre);
                Console.WriteLine("La fecha de ingreso es: "+request.FechaIngreso);
                Console.WriteLine("El grado es: " + request.Grado);
                Console.WriteLine("Su promedio es: "+request.Promedio);
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error :(" + ex.Message);
            }
        }
        public bool ValidarProm(double num1)
        {
            bool Validar=false;
            if(num1=> 7)
            {
                Validar=true;
            }
            return Validar;
        }
    }
}

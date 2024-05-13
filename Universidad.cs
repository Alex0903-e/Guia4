using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guia4.CarreraEstudiante;

namespace Guia4
{
   
    
        public class Universidad
        {
            public List<Alumno> Alumnos { get; set; }

            public Universidad()
            {
                Alumnos = new List<Alumno>();
                
            }

            public void AgregarAlumno(Alumno alumno)
            {
                Alumnos.Add(alumno);
            }

            public List<Alumno> ObtenerAlumnos()
            {
                return Alumnos;
            }
        }
         public enum CarreraEst
         {
           Ingenieria_de_Sistemas,
           Ingenieria_en_computacion,
           Telecomunicaciones,
           Ingenieria_Electronica,
         }
}

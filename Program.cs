using Guia4;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

public partial class Universidad
{
    public static Main(String[] args)
    {
    //Lista de ALumnos
    private List<Alumno> listaAlumnos;

    //Constructor para iniciar la lista de alum
    public Universidad()
    {
        List<Alumno> listaAlumnos = new List<Alumno>();

    }

    //Metodo estatico para agg a un alumno a la lista

    public void AgregarAlumno(Alumno alumno)
    {
        listaAlumnos.Add(alumno);

    }
    //Metodo estatico para mostrar la lista de alumnos con detalles

    public List<Alumno> ObtenerListaAlumnos()
    {
        return listaAlumnos;
    }

    public enum CarreraEst
    {
        Ingenieria_de_Sistemas,
        Ingenieria_en_computacion,
        Telecomunicaciones,
        Ingenieria_Electronica,
    }
  
 }  
}
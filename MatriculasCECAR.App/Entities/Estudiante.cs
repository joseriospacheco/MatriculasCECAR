namespace MatriculasCECAR.Domain.Entities;
public class Estudiante
{
    public string Identificacion { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public string Genero { get; set; }

    public Estudiante(string identificacion, string nombres, string apellidos, DateOnly fechaNacimiento, string genero)
    {
        Identificacion = identificacion;
        Nombres = nombres;
        Apellidos = apellidos;
        FechaNacimiento = fechaNacimiento;
        Genero = genero;
    }
}

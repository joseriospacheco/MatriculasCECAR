namespace MatriculasCECAR.Domain.Entities;
public class Matricula
{
    public Programa Programa { get; init; }
    public Estudiante Estudiante { get; set; }
    public DateTime Fecha { get; set; }
    public int Semestre { get; set; }

    public Matricula(Programa programa, Estudiante estudiante, DateTime fecha, int semestre)
    {
        Programa = programa;
        Estudiante = estudiante;
        Fecha = fecha;
        Semestre = semestre;
    }
}

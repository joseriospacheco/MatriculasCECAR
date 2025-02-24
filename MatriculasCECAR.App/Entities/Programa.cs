namespace MatriculasCECAR.Domain.Entities;
public class Programa
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Facultad { get; set; }

    public Programa(string codigo, string nombre, string facultad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Facultad = facultad;
    }
}

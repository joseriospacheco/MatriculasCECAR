using MatriculasCECAR.Domain.Entities;

namespace MatriculasCECAR.App;

internal class Program
{
    static void Main(string[] args)
    {


        var matriculas = new List<Matricula>();

        // Crear programas ficticios
        var programas = new List<Programa>
            {
                new("ING001", "Ingeniería de Sistemas", "Facultad de Ingeniería"),
                new("ADM002", "Administración de Empresas", "Facultad de Ciencias Económicas"),
                new("DER003", "Derecho", "Facultad de Derecho"),
                new("MED004", "Medicina", "Facultad de Ciencias de la Salud"),
                new("PSI005", "Psicología", "Facultad de Ciencias Sociales"),
                new("ARQ006", "Arquitectura", "Facultad de Arquitectura"),
                new("COM007", "Comunicación Social", "Facultad de Humanidades")
            };

        // Crear 30 estudiantes ficticios
        var estudiantes = new List<Estudiante>
            {
                new ("1001", "Juan", "Pérez", new DateOnly(2000, 5, 10), "Masculino"),
                new ("1002", "María", "López", new DateOnly(2001, 8, 20), "Femenino"),
                new ("1003", "Carlos", "González", new DateOnly(1999, 2, 15), "Masculino"),
                new ("1004", "Ana", "Martínez", new DateOnly(2002, 11, 5), "Femenino"),
                new ("1005", "Pedro", "Ramírez", new DateOnly(1998, 6, 25), "Masculino"),
                new ("1006", "Laura", "Fernández", new DateOnly(2000, 3, 12), "Femenino"),
                new ("1007", "Santiago", "Ortiz", new DateOnly(2001, 7, 30), "Masculino"),
                new ("1008", "Lucía", "Gómez", new DateOnly(1997, 9, 14), "Femenino"),
                new ("1009", "Andrés", "Morales", new DateOnly(2003, 1, 20), "Masculino"),
                new ("1010", "Carolina", "Ruiz", new DateOnly(1999, 4, 8), "Femenino"),
                new ("1011", "Luis", "Mendoza", new DateOnly(1998, 12, 2), "Masculino"),
                new ("1012", "Valeria", "Hernández", new DateOnly(2002, 10, 17), "Femenino"),
                new ("1013", "Jorge", "Suárez", new DateOnly(2000, 6, 3), "Masculino"),
                new ("1014", "Diana", "Vargas", new DateOnly(2003, 5, 23), "Femenino"),
                new ("1015", "Felipe", "Ríos", new DateOnly(2001, 2, 28), "Masculino"),
                new ("1016", "Camila", "Torres", new DateOnly(1997, 7, 18), "Femenino"),
                new ("1017", "Esteban", "Castro", new DateOnly(1999, 8, 9), "Masculino"),
                new ("1018", "Gabriela", "Luna", new DateOnly(2000, 9, 6), "Femenino"),
                new ("1019", "Héctor", "Velásquez", new DateOnly(2002, 12, 11), "Masculino"),
                new ("1020", "Sofía", "Jiménez", new DateOnly(2001, 3, 15), "Femenino"),
                new ("1021", "Fernando", "Reyes", new DateOnly(2003, 6, 22), "Masculino"),
                new ("1022", "Paula", "Salazar", new DateOnly(1998, 11, 1), "Femenino"),
                new ("1023", "Ricardo", "Ospina", new DateOnly(2000, 5, 4), "Masculino"),
                new ("1024", "Natalia", "Córdoba", new DateOnly(1999, 10, 10), "Femenino"),
                new ("1025", "Oscar", "Mejía", new DateOnly(2001, 1, 14), "Masculino"),
                new ("1026", "Eliana", "Zapata", new DateOnly(1997, 4, 29), "Femenino"),
                new ("1027", "Tomás", "Muñoz", new DateOnly(2002, 9, 21), "Masculino"),
                new ("1028", "Andrea", "Restrepo", new DateOnly(1999, 7, 12), "Femenino"),
                new ("1029", "David", "Palacios", new DateOnly(2000, 6, 7), "Masculino"),
                new ("1030", "Marcela", "Franco", new DateOnly(1998, 3, 25), "Femenino")
            };

        // Generar 15 matrículas ficticias aleatorias
        var semestreProgramaRandom = new Random();
        var numeroSemestreRandom = new Random();

        for (int i = 0; i < 15; i++)
        {
            var programaSeleccionado = programas[semestreProgramaRandom.Next(programas.Count)];
            var estudianteSeleccionado = estudiantes[semestreProgramaRandom.Next(estudiantes.Count)];

            var matricula = new Matricula(programaSeleccionado, estudianteSeleccionado, DateTime.Now, numeroSemestreRandom.Next(1, 10));
            matriculas.Add(matricula);
        }

        foreach (var matricula in matriculas)
        {
            Console.WriteLine($"Estudiante: {matricula.Estudiante.Nombres} {matricula.Estudiante.Apellidos}");
            Console.WriteLine($"Identificación: {matricula.Estudiante.Identificacion}");
            Console.WriteLine($"Programa: {matricula.Programa.Nombre}");
            Console.WriteLine($"Facultad: {matricula.Programa.Facultad}");
            Console.WriteLine($"Fecha de Matrícula: {matricula.Fecha}");
            Console.WriteLine(new string('-', 50));
        }
    }



}


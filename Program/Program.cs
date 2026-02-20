//NOMBRE: NAZARETH BELÉN DUBÓN JUÁREZ
//CUENTA:20221000123

using MiProyecto.Entidades;

List<Alumno> alumnos = new List<Alumno>();

alumnos.Add(new Alumno { Nombre = "Alex", Apellido = "Padilla", FechaNacimiento = new DateTime(2005, 5, 10), Nota = 85 });
alumnos.Add(new Alumno { Nombre = "Martha", Apellido = "Martinez", FechaNacimiento = new DateTime(2004, 8, 22), Nota = 92 });
alumnos.Add(new Alumno { Nombre = "Luis", Apellido = "Lopez", FechaNacimiento = new DateTime(2005, 1, 15), Nota = 70 });
alumnos.Add(new Alumno { Nombre = "José", Apellido = "Perez", FechaNacimiento = new DateTime(2003, 11, 30), Nota = 95 });
alumnos.Add(new Alumno { Nombre = "Lilian", Apellido = "Martinez", FechaNacimiento = new DateTime(2005, 5, 10), Nota = 60 });
alumnos.Add(new Alumno { Nombre = "Liliana", Apellido = "Rodriguez", FechaNacimiento = new DateTime(2004, 3, 12), Nota = 88 });
alumnos.Add(new Alumno { Nombre = "Ritza", Apellido = "Juárez", FechaNacimiento = new DateTime(2005, 7, 19), Nota = 75 });
alumnos.Add(new Alumno { Nombre = "Reina", Apellido = "Gallardo", FechaNacimiento = new DateTime(2004, 12, 5), Nota = 100 });

//FILTRO POR APELLIDO 
string apellidoBuscar = "Perez";
var filtroApellido = alumnos.Where(x => x.Apellido == apellidoBuscar).ToList();

Console.WriteLine($" Alumnos con apellido {apellidoBuscar}");
foreach (var a in filtroApellido)
{
    Console.WriteLine($"Nombre: {a.Nombre} {a.Apellido} | Nota: {a.Nota}");
}

// FILTRO POR FECHA DE NACIMIENTO 
DateTime fechaBuscar = new DateTime(2005, 5, 10);
var filtroFecha = alumnos.Where(x => x.FechaNacimiento == fechaBuscar).ToList();

Console.WriteLine($"\n Alumnos nacidos el {fechaBuscar.ToShortDateString()} ");
foreach (var a in filtroFecha)
{
    Console.WriteLine($"Nombre: {a.Nombre}  Fecha: {a.FechaNacimiento.ToShortDateString()}");
}

// FILTRO POR NOTA (Notas mayores a 70)
double notaMinima = 70;
var filtroNota = alumnos.Where(x => x.Nota > notaMinima).ToList();

Console.WriteLine($"\n Alumnos con nota mayor a {notaMinima} ");
foreach (var a in filtroNota)
{
    Console.WriteLine($"Nombre: {a.Nombre}  Nota: {a.Nota}");
}

// PROMEDIO DE NOTAS DE TODA LA CLASE 
double promedioNotas = alumnos.Average(x => x.Nota);
Console.WriteLine($"");
Console.WriteLine($"PROMEDIO GENERAL DE LA CLASE: {promedioNotas:N2}");
Console.WriteLine($"");
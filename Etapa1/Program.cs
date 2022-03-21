using CoreEscuela.Entidades;
using static System.Console;

var escuela = new Escuela(
    nombre: "PLatzi", año: 2002,
    Tipo: TiposEscuela.Primaria, Pais: "Vancouver"
);

escuela.TipoEscuela = TiposEscuela.PreEscolar;
escuela.Pais = "Colombia";
escuela.Ciudad = "Bucaramanga";
Console.WriteLine(escuela.ToString());


Curso[] arregloCurso = {
    new Curso()
    {
        Nombre = "101"
    },
    new Curso()
    {
        Nombre = "201"
    },
    new Curso()
    {
        Nombre = "301"
    }
};

escuela.Cursos = new Curso[]{
    new Curso()
    {
        Nombre = "101"
    },
    new Curso()
    {
        Nombre = "201"
    },
    new Curso()
    {
        Nombre = "301"
    }
};

System.Console.WriteLine("================");
ImprimirCursosEscuela(escuela);

void ImprimirCursosEscuela(Escuela escuela)
{
    Console.WriteLine("Cursos de la escuela =");

    if (escuela.Cursos != null && escuela != null || escuela?.Cursos != null)
    {
        foreach (var curso in escuela.Cursos)
        {
            WriteLine($"{curso.Nombre}-{curso.UniqueId}");
        }
    }


}

void ImprimirCursosWhile(Curso[] arregloCurso)
{
    int Cont = 0;
    while (Cont < arregloCurso.Count())
    {
        Console.WriteLine($"{arregloCurso[Cont].Nombre}, {arregloCurso[Cont].UniqueId}");
        Cont++;
    }
}

void ImprimirCursosDoWhile(Curso[] arregloCurso)
{
    int Cont = 0;
    do
    {
        Console.WriteLine($"{arregloCurso[Cont].Nombre}, {arregloCurso[Cont].UniqueId}");
        Cont++;

    } while (Cont < arregloCurso.Count());
}

void ImprimirCursosFor(Curso[] arregloCurso)
{
    for (int i = 0; i < arregloCurso.Count(); i++)
    {
        Console.WriteLine($"{arregloCurso[i].Nombre}-{arregloCurso[i].UniqueId}");
        Console.WriteLine("put Enter for continue");
        Console.ReadLine();
    }
}


void ImprimirCursosForEach(Curso[] arregloCurso)
{
    foreach (var curso in arregloCurso)
    {
        Console.WriteLine($"{curso.Nombre}-{curso.UniqueId}");
        Console.WriteLine("put Enter for continue");
        Console.ReadLine();
    }
}
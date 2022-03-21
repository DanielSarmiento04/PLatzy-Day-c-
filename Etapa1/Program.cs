using CoreEscuela.Entidades;


var escuela = new Escuela(
    nombre: "PLatzi", año: 2002,
    Tipo: TiposEscuela.Primaria, Pais: "Vancouver"
);

escuela.TipoEscuela = TiposEscuela.PreEscolar;
escuela.Pais = "Colombia";
escuela.Ciudad = "Bucaramanga";
Console.WriteLine(escuela.ToString());


var arregloCurso = new Curso[3];

arregloCurso[0] = new Curso()
{
    Nombre = "101"
};
var curso2 = new Curso()
{
    Nombre = "202"
};
arregloCurso[1] = curso2;

arregloCurso[2] = new Curso()
{
    Nombre = "301"
};
System.Console.WriteLine("================");

ImprimirCursosForEach(arregloCurso);
// ImprimirCursosWhile(arregloCurso);

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
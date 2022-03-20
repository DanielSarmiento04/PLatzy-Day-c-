using CoreEscuela.Entidades;


var escuela = new Escuela(
    nombre:"PLatzi",año:2002,
    Tipo: TiposEscuela.Primaria, Pais :"Vancouver"
);

escuela.TipoEscuela = TiposEscuela.PreEscolar;
escuela.Pais = "Colombia";
escuela.Ciudad = "Bucaramanga";
Console.WriteLine(escuela.ToString());


var arregloCurso = new Curso[3];

arregloCurso[0] = new Curso(){
    Nombre = "101"
};
var curso2 = new Curso(){
    Nombre = "202"
};
arregloCurso[1] = curso2;

arregloCurso[2] = new Curso(){
    Nombre = "301"
};
System.Console.WriteLine("================");

ImprimirCursos(arregloCurso);

void ImprimirCursos(Curso[] arregloCurso)
{
    int Cont = 0;
    while ( Cont < arregloCurso.Count())
    {
        Console.WriteLine($"{arregloCurso[Cont].Nombre}, {arregloCurso[Cont].UniqueId}");
        Cont++;
    }    
}

foreach (var curso in arregloCurso)
{
    Console.WriteLine($"{curso.Nombre}-{curso.UniqueId}");
    Console.WriteLine("put Enter for continue");
    Console.ReadLine();
}
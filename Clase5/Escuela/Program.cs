// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var miEscuela = new Escuela();
miEscuela.nombre = "Platzi Academy";
miEscuela.direccion = "Cra 9 calle 72";
miEscuela.anoFundacion = 2012;
Console.WriteLine("Timbrando");
miEscuela.Timbrar();  

class Escuela
{
    public string? nombre; //Se pone public para que se pueda acceder por fuera de la clase
    public string? direccion;   
    public int? anoFundacion;
    public string? ceo;

    public void Timbrar()
    {
        Console.Beep(900,3000);
    }
}

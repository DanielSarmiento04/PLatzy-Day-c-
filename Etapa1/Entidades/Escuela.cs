namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        string nombre;
        public string  Nombre {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AnoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        private int myVar;

        public Escuela(string Nombre, int AnoCreacion)
        {
            this.Nombre = Nombre;
            this.AnoCreacion = AnoCreacion;
        }
    }
}
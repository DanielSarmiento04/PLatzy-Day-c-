namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        string nombre;
        public string  Nombre {
            get { return $"Copia {nombre}"; }
            set { nombre = value.ToUpper(); }
        }
        public int AnoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        private int myVar;

        // public Escuela(string Nombre, int AnoCreacion)
        // {
        //     this.Nombre = Nombre;
        //     this.AnoCreacion = AnoCreacion;
        // }
        public override string ToString()
        {
            // return base.ToString();
            return $"Nombre \"{Nombre}\" tipo: {TipoEscuela}\nPais: {Pais}, Ciudad: {Ciudad}";
        }
        public Escuela (string nombre,int año) => (Nombre, AnoCreacion) = (nombre,año);
        public Escuela (string nombre,int año,TiposEscuela Tipo, string Pais = "",string Ciudad = "")
        {
            (Nombre, AnoCreacion) = (nombre,año);
            this.TipoEscuela = Tipo;
            this.Pais = Pais;
            this.Ciudad = Ciudad;
        }
    }
}
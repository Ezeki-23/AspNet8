namespace Backend.Modelos
{
    public class Empleado
    {
        public int Id { get; set; }
        public string NombreComp { get; set; }
        public string Correo { get; set; }
        public int Edad {  get; set; }
        public DateTime FechaInc { get; set; }
        public string Sexo { get; set; }
        public string Puesto { get; set; }
        public int Sueldo { get; set; }
    }
}

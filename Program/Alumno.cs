using System.Security.Cryptography.X509Certificates;

namespace MiProyecto.Entidades
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Nota { get; set; }

    }
}
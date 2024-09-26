namespace Entidad
{
    public class Familiar
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Parentesco { get; set; }
        public int Edad { get; set; }
        public string Etapa { get; set; } 
        public string NivelEscolaridad { get; set; }
        public string Ocupacion { get; set; }
        public bool RedCuidado { get; set; }
        public string NumeroContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}

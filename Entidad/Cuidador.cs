namespace Entidad
{
    public class Cuidador
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int Edad { get; set; }
        public bool SufreEnfermedad { get; set; }
        public string NumeroContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Parentesco { get; set; }
        public bool AfiliadoNuevaEPS { get; set; }
        public bool AsisteControlesMedicos { get; set; }
        public string ResultadoZarit { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}

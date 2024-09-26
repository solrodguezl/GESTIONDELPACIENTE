namespace Entidad.Enumeraciones
{
    public class EnfermedadCuidador
    {
        public int Id { get; set; }
        public string NombreEnfermedad { get; set; } 
        public int CuidadorId { get; set; }
        public Cuidador Cuidador { get; set; }
    }
}

using System;

namespace Entidad
{
     public class Paciente
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string DepartamentoResidencia { get; set; }
        public string MunicipioResidencia { get; set; }
        public string DireccionResidencia { get; set; }
        public bool ProveedorPrincipalHogar { get; set; }
        public string SituacionLaboral { get; set; }
        public string RecursosEconomicos { get; set; }
        public string NivelReduccionAutonomia { get; set; }
        public string TipoVivienda { get; set; }
    }
}

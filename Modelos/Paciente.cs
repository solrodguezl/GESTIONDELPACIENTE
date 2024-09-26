using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerNombre { get; set; }

        [StringLength(50)]
        public string SegundoNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerApellido { get; set; }

        [StringLength(50)]
        public string SegundoApellido { get; set; }

        [Required]
        [StringLength(20)]
        public string NumeroDocumento { get; set; }

        [Required]
        public string TipoDocumento { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Genero { get; set; }

        [StringLength(100)]
        public string DepartamentoResidencia { get; set; }

        [StringLength(100)]
        public string MunicipioResidencia { get; set; }

        [StringLength(200)]
        public string DireccionResidencia { get; set; }

        public bool ProveedorPrincipalHogar { get; set; }

        public string SituacionLaboral { get; set; }

        public string RecursosEconomicos { get; set; }

        public string NivelReduccionAutonomia { get; set; }

        public string TipoVivienda { get; set; }

        public virtual ICollection<Enfermedad> Enfermedades { get; set; }
        public virtual ICollection<Familiar> Familiares { get; set; }
        public virtual ICollection<Cuidador> Cuidadores { get; set; }
    }
}

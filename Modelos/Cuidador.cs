using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    internal class Cuidador
    {
        [Table("Cuidadores")]
        public class Cuidador
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string Nombres { get; set; }

            [StringLength(100)]
            public string Apellidos { get; set; }

            [Required]
            public string TipoDocumento { get; set; }

            [Required]
            [StringLength(20)]
            public string NumeroDocumento { get; set; }

            public int Edad { get; set; }

            public bool SufreEnfermedad { get; set; }

            [StringLength(15)]
            public string NumeroContacto { get; set; }

            [StringLength(100)]
            public string CorreoElectronico { get; set; }

            public string Parentesco { get; set; }

            public bool AfiliadoNuevaEPS { get; set; }

            public bool AsisteControlesMedicos { get; set; }

            public string ResultadoZarit { get; set; }

            public virtual ICollection<EnfermedadCuidador> EnfermedadesCuidador { get; set; }

            [ForeignKey("Paciente")]
            public int PacienteId { get; set; }

            public virtual Paciente Paciente { get; set; }
        }
    }
}

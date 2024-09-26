using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    internal class Familiar
    {
        [Table("Familiares")]
        public class Familiar
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string Nombres { get; set; }

            [StringLength(100)]
            public string Apellidos { get; set; }

            [Required]
            public string Parentesco { get; set; }

            public int Edad { get; set; }

            public string Etapa { get; set; }

            public string NivelEscolaridad { get; set; }

            public string Ocupacion { get; set; }

            public bool RedCuidado { get; set; }

            [StringLength(15)]
            public string NumeroContacto { get; set; }

            [StringLength(100)]
            public string CorreoElectronico { get; set; }

            [ForeignKey("Paciente")]
            public int PacienteId { get; set; }

            public virtual Paciente Paciente { get; set; }
        }
    }
}

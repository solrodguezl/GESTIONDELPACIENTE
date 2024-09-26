using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Enfermedad
    {
        [Table("Enfermedades")]
        public class Enfermedad
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string NombreEnfermedad { get; set; }

            [ForeignKey("Paciente")]
            public int PacienteId { get; set; }

            public virtual Paciente Paciente { get; set; }
        }

    }

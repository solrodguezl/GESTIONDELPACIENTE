using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entidad
{
    internal class EnfermedadCuidador
    {
        [Table("EnfermedadesCuidador")]
        public class EnfermedadCuidador
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string NombreEnfermedad { get; set; }

            [ForeignKey("Cuidador")]
            public int CuidadorId { get; set; }

            public virtual Cuidador Cuidador { get; set; }
        }

    }
}

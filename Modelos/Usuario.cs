using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{

    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public int PacienteId { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}


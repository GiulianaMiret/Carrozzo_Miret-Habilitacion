using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Core.Models
{
    public class Socio
    {
        public int Id { get; set; }

        public int NroSocio { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaRenuncia { get; set; }

        public String MotivoRenuncia { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }

        public virtual Persona Persona { get; set; }
    }
}

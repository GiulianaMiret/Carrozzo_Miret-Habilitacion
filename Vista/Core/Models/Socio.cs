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

        public int Dni { get; set; }

        public int NroSocio { get; set; }

        public String Apellido { get; set; }

        public String Nombre { get; set; }

        public String Domicilio { get; set; }

        public String Nacionalidad { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaRenuncia { get; set; }

        public String MotivoRenuncia { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }
    }
}

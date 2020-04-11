using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Core.Models
{
    public class Pago
    {
        public int Id { get; set; }

        public int Anio { get; set; }

        public int MesCuota { get; set; }

        public Double MontoCuota { get; set; }

        public DateTime Fecha { get; set; }

        public virtual Socio Socio { get; set; }

        public virtual Transaccion Transaccion { get; set; }
    }
}

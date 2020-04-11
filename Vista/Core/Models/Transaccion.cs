using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Core.Models
{
    public class Transaccion
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        public Double Monto { get; set; }

        public String Detalle { get; set; }

        public String NroFactura { get; set; }

        public enum TipoTransaccion { Ingreso, Egreso }

        public String TipoIngresoEgreso { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }
    }
}

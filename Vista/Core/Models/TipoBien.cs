using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Core.Models
{
    public class TipoBien
    {
        public int Id { get; set; }

        public String Detalle { get; set; }

        public int CantidadTotal { get; set; }

        public int CantidadConSubsidio { get; set; }

        public virtual Rubro Rubro { get; set; }

        public virtual ICollection<Modificacion> Modificaciones { get; set; }
    }
}

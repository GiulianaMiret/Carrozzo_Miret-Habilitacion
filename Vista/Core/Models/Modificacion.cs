using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Core.Models
{
   public class Modificacion
   {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public String Operacion { get; set; }

        public int Cantidad { get; set; }

        public Boolean SubsidioNacional { get; set; }

        public int CantidadConSubsidio { get; set; }

        public virtual TipoBien TipoBien { get; set; }
   }
}

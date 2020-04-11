using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Core.Models
{
    public class Rubro
    {
        public int Id { get; set; }

        public String Descripcion { get; set; }

        public Boolean Activo { get; set; }

        public virtual ICollection<TipoBien> TiposBienes { get; set; }
    }
}

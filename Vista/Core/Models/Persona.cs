using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Core.Models
{
    public class Persona
    {
        public int Id { get; set; }

        public int Dni { get; set; }

        public String Apellido { get; set; }

        public String Nombre { get; set; }

        public String Domicilio { get; set; }

        public String Nacionalidad { get; set; }

        public virtual ICollection<Socio> Socios { get; set; }
    }
}

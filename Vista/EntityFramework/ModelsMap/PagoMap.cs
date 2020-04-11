using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;


namespace Vista.EntityFramework.ModelsMap
{
    public class PagoMap : EntityTypeConfiguration<Pago>
    {
        public PagoMap()
        {
            this.HasKey(x => x.Id);

            this.Property(a => a.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(x => x.Transaccion);
        }
    }
}

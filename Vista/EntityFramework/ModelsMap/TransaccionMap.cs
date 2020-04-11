using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;

namespace Vista.EntityFramework.ModelsMap
{
    public class TransaccionMap : EntityTypeConfiguration<Transaccion>
    {
        public TransaccionMap()
        {
            this.HasKey(x => x.Id);

            this.Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasMany(x => x.Pagos)
                .WithOptional(p => p.Transaccion);
        }
    }
}

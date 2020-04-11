using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Core.Models;

namespace Vista.EntityFramework.ModelsMap
{
    public class SocioMap : EntityTypeConfiguration<Socio>
    {
        public SocioMap()
        {
            this.HasKey(x => x.Id);

            this.Property(a => a.Id)
                            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nombre)
                            .IsRequired();

            this.Property(p => p.Dni)
                            .IsRequired();

            this.Property(x => x.FechaRenuncia).HasColumnType("datetime2");
        }
    }
}

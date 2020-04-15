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
    class PersonaMap : EntityTypeConfiguration<Persona>
    {
        public PersonaMap()
        {
            this.HasKey(x => x.Id);

            this.Property(a => a.Id)
                            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nombre)
                            .IsRequired();

            this.Property(p => p.Dni)
                            .IsRequired();

            this.HasMany(x => x.Socios)
                .WithRequired(y => y.Persona);
        }
    }
}

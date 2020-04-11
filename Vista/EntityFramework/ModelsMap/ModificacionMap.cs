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
    class ModificacionMap : EntityTypeConfiguration<Modificacion>
    {
        public ModificacionMap()
        {
            this.HasKey(x => x.Id);

            this.Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}

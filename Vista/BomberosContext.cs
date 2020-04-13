using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;
using Vista.EntityFramework.ModelsMap;

namespace EntityFramework
{
    public class BomberosContext : DbContext
    {
        public DbSet<Socio> Socios { get; set; }

        public DbSet<Pago> Pagos { get; set; }

        public DbSet<Transaccion> Transacciones { get; set; }

        public DbSet<Modificacion> Modificaciones { get; set; }

        public DbSet<TipoBien> TipoBienes { get; set; }

        public DbSet<Rubro> TipoRubros { get; set; }

        public DbSet<Persona> Personas { get; set; }


        public BomberosContext() : base("name=Default")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BomberosContext>());
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SocioMap());
            modelBuilder.Configurations.Add(new PagoMap());
            modelBuilder.Configurations.Add(new TransaccionMap());
            modelBuilder.Configurations.Add(new RubroMap());
            modelBuilder.Configurations.Add(new ModificacionMap());
            modelBuilder.Configurations.Add(new TipoBienMap());
            modelBuilder.Configurations.Add(new PersonaMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}

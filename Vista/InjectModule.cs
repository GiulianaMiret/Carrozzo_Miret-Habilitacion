using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using EntityFramework.Services;
using EntityFramework;
using Controlador;
using log4net;
using log4net.Core;
using Vista.Logger;
using Vista.EntityFramework.Services;
using System.Data.Entity;
using Vista.Core.Models;

namespace Vista
{
    public class InjectModule : NinjectModule
    {

        public override void Load()
        {
            //Bindeamos las inyecciones de dependencias y las hacemos Singleton , es decir, una sola instancia de las variables para toda la ejecucion del programa.
            Bind<ISocioRepository>().To<SocioRepository>().InSingletonScope();
            Bind<IPagoRepository>().To<PagoRepository>().InSingletonScope();
            Bind<ITransaccionRepository>().To<TransaccionRepository>().InSingletonScope();
            Bind<IModificacionRespository>().To<ModificacionRepository>().InSingletonScope();
            Bind<ITipoBienRepository>().To<TipoBienRepository>().InSingletonScope();
            Bind<IRubroRepository>().To<RubroRepository>().InSingletonScope();
            Bind<IPersonaRepository>().To<PersonaRepository>().InSingletonScope();


            Bind<IRepository<Socio>>().To<RepositoryBase<Socio>>().InSingletonScope();
            Bind<IRepository<Pago>>().To<RepositoryBase<Pago>>().InSingletonScope();
            Bind<IRepository<Transaccion>>().To<RepositoryBase<Transaccion>>().InSingletonScope();
            Bind<IRepository<Modificacion>>().To<RepositoryBase<Modificacion>>().InSingletonScope();
            Bind<IRepository<TipoBien>>().To<RepositoryBase<TipoBien>>().InSingletonScope();
            Bind<IRepository<Rubro>>().To<RepositoryBase<Rubro>>().InSingletonScope();
            Bind<IRepository<Persona>>().To<RepositoryBase<Persona>>().InSingletonScope();
            Bind<Fachada>().ToSelf().InSingletonScope();
            Bind<BomberosContext>().To<BomberosContext>().InSingletonScope();
            Bind<Vista.Logger.ILogger>().To<Logger4net>().InSingletonScope();
        }
    }
}

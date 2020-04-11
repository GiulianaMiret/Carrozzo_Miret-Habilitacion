using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows.Forms;
using Vista;
using Vista.Logger;
using Vista.EntityFramework.Services;
using Vista.Core.Models;
using System.Data.Entity;
using System.Drawing;

namespace Controlador
{
    /// <summary>
    /// Clase fachada, de donde se va a llamar a los repositorios para realizar las operaciones
    /// </summary>
    public class Fachada
    {
        /// <summary>
        /// Declaramos las variables repositorios de solo lectura, que se inyectarán con Ninject.
        /// </summary>
        private readonly ISocioRepository cSocioRepository;
        private readonly IPagoRepository cPagoRepository;
        private readonly ITransaccionRepository cTransaccionRepository;
        private readonly ITipoBienRepository cTipoBienRepository;
        private readonly IModificacionRespository cModificacionRespository;
        private readonly IRubroRepository cRubroRepository;
        private readonly IRepository<Pago> cRepositoryBasePago;
        private readonly IRepository<Transaccion> cRepositoryBaseTransaccion;
        private readonly IRepository<Rubro> cRepositoryBaseRubro;
        private readonly IRepository<Modificacion> cRepositoryBasModificacion;
        private readonly IRepository<TipoBien> cRepositoryBaseTipobien;
        private readonly ILogger cLogger;
        /// <summary>
        /// Constructor de la clase Fachada que basicamente inyecta las dependencias de los repositorios con Ninject.
        /// </summary>
        public Fachada(ISocioRepository pSocioRepository,
                       IPagoRepository pPagoRepository,
                       ITransaccionRepository pTransaccionRepository,
                       ITipoBienRepository pTipoBienRepository,
                       IModificacionRespository pModificacionRespository,
                       IRubroRepository pRubroRepository,
                       IRepository<Pago> pRepositoryBasePago,
                       IRepository<Transaccion> pRepositoryBaseTransaccion,
                       IRepository<Rubro> pRepositoryBaseRubro,
                       IRepository<Modificacion> pRepositoryBasModificacion,
                       IRepository<TipoBien> pRepositoryBaseTipobien,
                       ILogger pLogger)
        {
            cSocioRepository = pSocioRepository;
            cPagoRepository = pPagoRepository;
            cTransaccionRepository = pTransaccionRepository;
            cTipoBienRepository = pTipoBienRepository;
            cModificacionRespository =pModificacionRespository;
            cRubroRepository = pRubroRepository;
            cRepositoryBasePago = pRepositoryBasePago;
            cRepositoryBaseTransaccion = pRepositoryBaseTransaccion;
            cRepositoryBaseRubro = pRepositoryBaseRubro;
            cRepositoryBasModificacion = pRepositoryBasModificacion;
            cRepositoryBaseTipobien = pRepositoryBaseTipobien;
            cLogger = pLogger;
        }

        public void addSocio(Socio pSocio)
        {
            try
            {
                cSocioRepository.Add(pSocio);
                cSocioRepository.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Socio findByNroSocio(int pNroSocio)
        {
            return cSocioRepository.Filter(x => x.NroSocio == pNroSocio).ToList().FirstOrDefault();
        }

        public void updateSocio(Socio pSocio)
        {
            cSocioRepository.Update(pSocio);
            cSocioRepository.SaveChanges();
        }

        public int getNextNroSocio()
        {
            return cSocioRepository.getMaxNroSocio() + 1;
        }
    }
}

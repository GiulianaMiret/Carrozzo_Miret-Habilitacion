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

namespace Vista.Fachada
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
        private readonly IPersonaRepository cPersonaRepository;
        private readonly IRepository<Persona> cRepositoryBasePersona;
        private readonly IRepository<Pago> cRepositoryBasePago;
        private readonly IRepository<Socio> cRepositoryBaseSocio;
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
                       IPersonaRepository pPersonaRepository,
                       IRepository<Persona> pRepositoryBasePersona,
                       IRepository<Pago> pRepositoryBasePago,
                       IRepository<Socio> pRepositoryBaseSocio,
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
            cModificacionRespository = pModificacionRespository;
            cRubroRepository = pRubroRepository;
            cPersonaRepository = pPersonaRepository;
            cRepositoryBasePersona = pRepositoryBasePersona;
            cRepositoryBasePago = pRepositoryBasePago;
            cRepositoryBaseSocio = pRepositoryBaseSocio;
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
                cRepositoryBaseSocio.Add(pSocio);
                cRepositoryBaseSocio.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void addPersona(Persona pPersona)
        {
            try
            {
                List<Persona> personas = cRepositoryBasePersona.Filter(x => x.Dni == pPersona.Dni).ToList();
                if (personas.Count() > 0)
                {
                    throw new Exception("La persona ya existe");
                }
                else
                {
                    cRepositoryBasePersona.Add(pPersona);
                    cRepositoryBasePersona.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Socio> findByNroSocio(int pNroSocio)
        {
            return cRepositoryBaseSocio.Filter(x => x.NroSocio == pNroSocio).ToList();
        }

        public void updateSocio(Socio pSocio)
        {
            cRepositoryBaseSocio.Update(pSocio);
            cRepositoryBaseSocio.SaveChanges();
        }

        public void updatePersona(Persona pPersona)
        {
            cRepositoryBasePersona.Update(pPersona);
            cRepositoryBasePersona.SaveChanges();
        }

        public int getNextNroSocio()
        {
            return cSocioRepository.getMaxNroSocio() + 1;
        }

        public Boolean esSocioActivo(Socio pSocio)
        {
            if ((pSocio.MotivoRenuncia != null || pSocio.MotivoRenuncia != "") && pSocio.FechaRenuncia.Year > 1900)
            {
                return false;
            }
            return true;
        }

        public Socio getLastSocioInactivoByNro(int pNroSocio)
        {
            return cRepositoryBaseSocio.Filter(x => x.NroSocio == pNroSocio && this.esSocioActivo(x)).ToList().
                                           OrderByDescending(y => y.FechaRenuncia).ToList().FirstOrDefault();
        }

        public List<Socio> getAllSocios()
        {
            return cRepositoryBaseSocio.GetAll().ToList();
        }

        public Socio findSocioById(int pIdSocio)
        {
            return cRepositoryBaseSocio.Filter(x => x.Id == pIdSocio).FirstOrDefault();
        }

        public Socio findSocioActivoByDni(int pDNISocio)
        {
            return cRepositoryBaseSocio.Filter(x => x.Persona.Dni == pDNISocio && esSocioActivo(x)).FirstOrDefault();
        }

        public void activarSocio(Socio pSocio)
        {
            try
            {
                Socio socioNuevo = new Socio();
                socioNuevo.Persona = pSocio.Persona;
                socioNuevo.NroSocio = pSocio.NroSocio;
                socioNuevo.FechaIngreso = pSocio.FechaIngreso;
                socioNuevo.MotivoRenuncia = null;
                socioNuevo.FechaRenuncia = new DateTime(0001, 01, 01, 00, 00, 00);
                updatePersona(socioNuevo.Persona);
                cRepositoryBaseSocio.Add(socioNuevo);
                cRepositoryBaseSocio.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Persona findPersonaByDni(int pDNI)
        {
            return cRepositoryBasePersona.Filter(x => x.Dni == pDNI).FirstOrDefault();
        }

        public IEnumerable<Socio> findDeudores(IEnumerable<Socio> listasocios)
        {
            return listasocios.Where(x =>
                    !cPagoRepository.esCuotaPaga(DateTime.Now.Month, DateTime.Now.Year, x.Id)).ToList();
        }

        public IEnumerable<Socio> findSociosAlDia(IEnumerable<Socio> listasocios)
        {
            return listasocios.Where(x =>
                    cPagoRepository.esCuotaPaga(DateTime.Now.Month, DateTime.Now.Year, x.Id)).ToList();
        }

        public int getCantidadCuotasAdeudadas(Socio pSocio)
        {
            return cPagoRepository.getCantidadCuotasAdeudadas(pSocio);
        }

        public Pago ultimaCuotaPaga(int idSocio)
        {
            return cPagoRepository.getUltimoPago(idSocio);
        }

        public void addRubro(Rubro pRubro)
        {
            try
            {
                cRepositoryBaseRubro.Add(pRubro);
                cRepositoryBaseRubro.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Rubro> getAllRubros()
        {
            try
            {
                return cRepositoryBaseRubro.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteRubro(Rubro pRubro)
        {
            try
            {
                cRepositoryBaseRubro.DeleteById(pRubro.Id);
                cRepositoryBaseRubro.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public void updateRubro(Rubro pRubro)
        {
            try
            {
                cRepositoryBaseRubro.Update(pRubro);
                cRepositoryBaseRubro.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

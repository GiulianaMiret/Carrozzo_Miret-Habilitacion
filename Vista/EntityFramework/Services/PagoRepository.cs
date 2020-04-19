using EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;

namespace Vista.EntityFramework.Services
{
    public class PagoRepository : IPagoRepository
    {
        private DbSet<Pago> cDbSetPago;
        private readonly BomberosContext cBomberosContext;
        private readonly ISocioRepository cSocioRepository;
        
        public PagoRepository(BomberosContext pContext, ISocioRepository pSocioRepository)
        {
            cDbSetPago = pContext.Set<Pago>();
            cBomberosContext = pContext;
            cSocioRepository = pSocioRepository;
        }

        public bool esCuotaPaga(int pMes, int pAnio, int idSocio)
        {
            Pago pago = cDbSetPago.Where(x => x.Socio.Id == idSocio && x.MesCuota == pMes && x.Anio == pAnio).FirstOrDefault();
            if(pago != null)
            {
                return true;
            }
            return false;
        }

        public int getCantidadCuotasAdeudadas(Socio pSocio)
        {
            if (!esCuotaPaga(DateTime.Now.Month, DateTime.Now.Year, pSocio.Id))
            {
                int cuotas = 0;
                Pago ultimoPago = getUltimoPago(pSocio.Id);
                int anioPago = 0;
                int mesPago = 0;
                if (ultimoPago == null) {
                    anioPago = pSocio.FechaIngreso.Year;
                    mesPago = pSocio.FechaIngreso.Month;
                } else
                {
                    anioPago = ultimoPago.Anio;
                    mesPago = ultimoPago.MesCuota;
                }
                if(DateTime.Now.Year == anioPago)
                {
                    cuotas = DateTime.Now.Month - mesPago;
                } else
                {
                    int difAnio = DateTime.Now.Year - anioPago;
                    for (int i = anioPago; i < DateTime.Now.Year; i++){
                        cuotas += 12 - mesPago;
                    }
                    if(DateTime.Now.Month - mesPago > 0)
                    {
                        cuotas += DateTime.Now.Month - mesPago;
                    } else
                    {
                        cuotas += mesPago - DateTime.Now.Month;
                    }
                    
                }
                return cuotas;
            }
            return 0;
        }

        public Pago getUltimoPago(int idSocio)
        {
            return cDbSetPago.Where(x => x.Socio.Id == idSocio)
                                .OrderByDescending(y => y.Anio + y.MesCuota).FirstOrDefault();

        }
    }
}

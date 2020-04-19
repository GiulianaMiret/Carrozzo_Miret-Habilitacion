using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;

namespace Vista.EntityFramework.Services
{
    public interface IPagoRepository
    {
        bool esCuotaPaga(int pMes, int pAnio, int idSocio);

        int getCantidadCuotasAdeudadas(Socio pSocio);

        Pago getUltimoPago(int idSocio);
    }
}

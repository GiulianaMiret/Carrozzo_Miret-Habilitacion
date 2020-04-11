using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;
using System.Data.Entity;
using EntityFramework;
using EntityFramework.Services;
using System.Linq.Expressions;

namespace Vista.EntityFramework.Services
{
    public class SocioRepository : ISocioRepository
    {
        private readonly BomberosContext cBomberosContext;
        private DbSet<Socio> cDbSet;

        public SocioRepository(BomberosContext pContext)
        {
            cBomberosContext = pContext;
            cDbSet = pContext.Set<Socio>();
        }

        public void Add(Socio pSocio)
        {
            List<Socio> socios = this.Filter(x => x.Dni == pSocio.Dni).ToList();
            if(socios.Count() > 0)
            {
                throw new Exception("El DNI ya se encuentra registrado"); 
            } else
            {
                cDbSet.Add(pSocio);
            }
            
        }

        public void Update(Socio pSocio)
        {
            List<Socio> socios = this.Filter(x => x.Dni == pSocio.Dni).ToList();
            if (socios.Count() > 0)
            {
                throw new Exception("El DNI ya se encuentra registrado");
            } else
            {
                if (cBomberosContext.Entry(pSocio).State == EntityState.Detached)
                {
                    cDbSet.Attach(pSocio);
                }
                cBomberosContext.Entry(pSocio).State = EntityState.Modified;
            }
        }

        public IQueryable<Socio> Filter(Expression<Func<Socio, bool>> expresion)
        {
            return cDbSet.Where(expresion);
        }

        public Socio GetById(int pId)
        {
            return cDbSet.Find(pId);
        }

        public void DeleteById(int pId)
        {
            Socio entityToDelete = cDbSet.Find(pId);
            this.Delete(entityToDelete);
        }

        public void Delete(Socio pSocio)
        {
            if (cBomberosContext.Entry(pSocio).State == EntityState.Detached)
            {
                cDbSet.Attach(pSocio);
            }
            cDbSet.Remove(pSocio);
            cBomberosContext.SaveChanges();
        }

        public IQueryable<Socio> GetAll()
        {
            return cDbSet;
        }

        public void SaveChanges()
        {
            cBomberosContext.SaveChanges();
        }

        public int getMaxNroSocio()
        {
            return cDbSet.Max(x => x.NroSocio);
        }
    }
}

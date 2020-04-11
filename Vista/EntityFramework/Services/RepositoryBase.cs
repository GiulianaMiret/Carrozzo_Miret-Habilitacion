using EntityFramework;
using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Vista.EntityFramework.Services
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly BomberosContext cBomberosContext;
        private DbSet<T> cDbSet;

        public RepositoryBase(BomberosContext pContext)
        {
            cBomberosContext = pContext;
            cDbSet = pContext.Set<T>();
        }

        public void Add(T pEntity)
        {
            cDbSet.Add(pEntity);
        }

        public void Update(T pEntity)
        {
            if (cBomberosContext.Entry(pEntity).State == EntityState.Detached)
            {
                cDbSet.Attach(pEntity);
            }
            cBomberosContext.Entry(pEntity).State = EntityState.Modified;
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> expresion)
        {
            return cDbSet.Where(expresion);
        }

        public T GetById(int pId)
        {
            return cDbSet.Find(pId);
        }

        public void DeleteById(int pId)
        {
            T entityToDelete = cDbSet.Find(pId);
            this.Delete(entityToDelete);
        }

        public void Delete(T pEntity)
        {
            if (cBomberosContext.Entry(pEntity).State == EntityState.Detached)
            {
                cDbSet.Attach(pEntity);
            }
            cDbSet.Remove(pEntity);
            cBomberosContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return cDbSet;
        }

        public void SaveChanges()
        {
            cBomberosContext.SaveChanges();
        }

    }
}

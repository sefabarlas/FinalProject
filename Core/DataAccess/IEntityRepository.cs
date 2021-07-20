using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic constraint
    //class : referans tip olabilir.
    //IEntity : IEntity olabilir veya IEntity implemete eden sınııfta olabilir.
    //new() : new' lenebilir olmalı.Interface newlenemez. Ienntity gellmemesi içim.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtre vermeyebilir
        T Get(Expression<Func<T, bool>> filter); // filtre zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

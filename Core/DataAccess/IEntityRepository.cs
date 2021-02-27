using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        List<T> GetById(string id);
        List<T> GetByBrandId(string id);
        List<T> GetByColorId(string id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

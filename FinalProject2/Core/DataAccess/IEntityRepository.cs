using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
    //Core .Net core ile alakalı değil, genel kullanmak için oluşturduk
{
    //class: refereans tip
    //IEntity: IEntity veya IEntity implemente eden nesne
    //new(): newlenebilir olmalı(IEntity kendisi olamaz)
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    //generic constraint (Generic Kısıt; sadece istediğimzi nesneler verilebilsin)
    //class : referans tip olmalı
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir demek
    //new() : new'lenebilir olmalı, çünkü IEntity nesnesini verememeli
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}

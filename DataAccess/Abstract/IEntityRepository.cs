﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new() //Generic Constraint, T'nin ne olabileceği hakkında şart koyduk.
    {
        //GetAll(p => p.CategoryId == 2) gibi işlemler yapabilmek için expression kullandık. LINQ ile beraber geliyor.
        //Bu sayede kategoriye göre getir, ürüne göre getir vb. için ayrı ayrı metodlar yazmak gerekmeyecek.
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // filter=null filtre vermeyebilirsin, delegate yapıları denir.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

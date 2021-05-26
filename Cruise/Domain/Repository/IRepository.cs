﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        
        TEntity Insert(TEntity entity);
        
        void Update(TEntity entity);
        
        TEntity GetById(object id);

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null
        );

        void Delete(TEntity entity);

        void Delete(object id);
    }
}
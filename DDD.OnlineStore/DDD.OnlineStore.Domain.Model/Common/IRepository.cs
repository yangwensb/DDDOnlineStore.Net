﻿using DDD.OnlineStore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.OnlineStore.Domain.Common
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : IEntity
    {
        IQueryable<TEntity> Queryable { get; }

        TEntity GetByID(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> GetAll();
        void Save();
    }
}

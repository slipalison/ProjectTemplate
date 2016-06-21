﻿using System;
using System.Collections.Generic;
using ProgectTemplate.Business.Interfaces.Repository;
using System.Data.Entity;
using System.Linq;

namespace ProgectTemplate.Repository.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IWrite<TEntity>, IRead<TEntity> where TEntity : class
    {
        protected Context.Context Db;
        protected DbSet<TEntity> DbSet;
        public RepositoryBase(Context.Context context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        #region Write
        public TEntity Create(TEntity obj) => DbSet.Add(obj);

        public virtual void Delete(long id) => DbSet.Remove(DbSet.Find(id));

        public virtual TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }
        #endregion
      
        #region Read
        public IEnumerable<TEntity> GetAll() => DbSet.ToList();

        public TEntity GetById(int id) => DbSet.Find(id);
        #endregion

        public int SaveChanges() => Db.SaveChanges();

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}

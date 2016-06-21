using ProgectTemplate.Business.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProgectTemplate.Repository.Repository
{
    public class RepositoryViewBase<TEntity> : IRead<TEntity> where TEntity : class
    {
        protected Context.Context Db;
        protected DbSet<TEntity> DbSet;
        public RepositoryViewBase(Context.Context context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll() => DbSet.ToList();

        public TEntity GetById(int id) => DbSet.Find(id);
    }
}

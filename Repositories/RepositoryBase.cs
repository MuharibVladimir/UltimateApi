﻿using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public void Create(T entity)
        {
            _repositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _repositoryContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges ? 
                _repositoryContext.Set<T>().AsNoTracking() :
                _repositoryContext.Set<T>();
        }

        public IQueryable<T> FindByCondiiton(System.Linq.Expressions.Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return !trackChanges ?
                _repositoryContext.Set<T>().Where(expression).AsNoTracking() :
                _repositoryContext.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            _repositoryContext.Set<T>().Update(entity); 
        }
    }
}

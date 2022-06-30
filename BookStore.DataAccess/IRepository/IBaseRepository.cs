﻿namespace BookStore.DataAccess.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] navigationProperties);
        T FindObject(Expression<Func<T, bool>> filter);
        T FindObject(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] navigationProperties);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}

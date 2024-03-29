﻿namespace FashionStore.Api.Interfaces.IRepos
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(object id);
        Task<IEnumerable<TEntity>> GetAlls();
        Task AddAsync(TEntity entity);
        Task Delete(object id);
        void Delete(TEntity entity);      
    }
}

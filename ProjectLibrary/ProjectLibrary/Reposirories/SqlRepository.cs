﻿
using Microsoft.EntityFrameworkCore;
using ProjectLibrary.Entities;

namespace ProjectLibrary.Reposirories
{
    public class SqlRepository<T> where T: class, IEntity, new() 
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(item => item.Id).ToList();
        }
        
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T item) 
        { 
            _dbSet.Add(item);
        }
        public void Remove(T item) 
        { 
            _dbSet.Remove(item);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

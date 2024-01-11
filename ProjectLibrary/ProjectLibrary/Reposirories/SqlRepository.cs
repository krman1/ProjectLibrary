
using Microsoft.EntityFrameworkCore;
using ProjectLibrary.Entities;
public delegate void ItemAdded<in T>(T item);

namespace ProjectLibrary.Reposirories
{
    public class SqlRepository<T> : IRepository<T> where T: class, IEntity, new() 
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        private readonly Action<T>? _itemAddedCallBack;

        public SqlRepository(DbContext dbContext, Action<T>? itemAddedCallBack = null)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
           _itemAddedCallBack = itemAddedCallBack;
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(item => item.Id).ToList();
        }
        
        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T item) 
        { 
            _dbSet.Add(item);
            _itemAddedCallBack?.Invoke(item);
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

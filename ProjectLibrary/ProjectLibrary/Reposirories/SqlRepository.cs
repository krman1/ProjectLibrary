
using Microsoft.EntityFrameworkCore;
using ProjectLibrary.Entities;

namespace ProjectLibrary.Reposirories
{
    public class SqlRepository
    {
        private readonly DbSet<Project> _dbSet;
        private readonly DbContext _dbContext;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Project>();
        }
        public Project? GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(Project item) 
        { 
            _dbSet.Add(item);
        }
        public void Remove(Project item) 
        { 
            _dbSet.Remove(item);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

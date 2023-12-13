using ProjectLibrary.Entities;

namespace ProjectLibrary.Reposirories
{
    public class ListProjectRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly List<T> _items = new();
        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
        public void Add(T item) 
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void Save()
        {
            //save is not required with list
        }
        public void Remove(T item) 
        {
            _items.Remove(item);
        }
       
    }
}

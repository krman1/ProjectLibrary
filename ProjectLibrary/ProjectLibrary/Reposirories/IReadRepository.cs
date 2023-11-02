
using ProjectLibrary.Entities;

namespace ProjectLibrary.Reposirories
{
    public interface IReadRepository<in T> where T : class, IEntity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}

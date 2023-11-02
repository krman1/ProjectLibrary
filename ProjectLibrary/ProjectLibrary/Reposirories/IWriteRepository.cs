
using ProjectLibrary.Entities;

namespace ProjectLibrary.Reposirories
{
    public interface IWriteRepository<out T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}

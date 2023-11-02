
using ProjectLibrary.Entities;

namespace ProjectLibrary.Reposirories
{
    public interface IRepository<T> : IWriteRepository<T>, IReadRepository<T> where T : IEntity
    {

    }

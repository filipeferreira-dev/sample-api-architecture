using System.Linq;

namespace Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : class 
    {
        IUnitOfWork UnitOfWork { get; }

        IQueryable<T> Get();

    }
}

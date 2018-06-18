using System.Linq;
using Domain.Interfaces;
using Domain.Interfaces.Repository;

namespace Infrastructure.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        #region Properties

        public IUnitOfWork UnitOfWork { get; private set; }

        #endregion

        #region Constructors

        protected Repository(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        public abstract IQueryable<T> Get();

        #endregion
    }
}

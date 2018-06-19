using Domain.Services.Interfaces.Repository;
using Infrastructure.Data.Context;
using System.Collections.Generic;

namespace Infrastructure.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        #region Properties

        protected SampleContext Db { get; }

        #endregion

        #region Constructors

        protected Repository(SampleContext context)
        {
            Db = context;
        }

        #endregion

        #region Methods

        public abstract IList<T> Get();

        #endregion
    }
}

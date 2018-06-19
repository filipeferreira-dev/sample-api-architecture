using System.Collections.Generic;

namespace Domain.Services.Interfaces.Repository
{
    public interface IRepository<T> where T : class 
    {
        IList<T> Get();
    }
}

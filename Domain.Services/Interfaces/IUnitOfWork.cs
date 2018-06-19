using System;

namespace Domain.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable 
    {
        bool Commit();
    }
}

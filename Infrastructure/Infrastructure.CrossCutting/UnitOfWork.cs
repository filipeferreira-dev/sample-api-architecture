using Domain.Interfaces;
using Infrastructure.Data.Context;

namespace Infrastructure.CrossCutting
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleContext _context;

        public UnitOfWork(SampleContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

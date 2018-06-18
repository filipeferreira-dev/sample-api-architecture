using Domain.Interfaces;
using Infrastructure.Data.Context;

namespace Infrastructure.CrossCutting
{
    public class UnitOfWork : IUnitOfWork<SampleContext>
    {
        public SampleContext Db { get; private set; }

        public UnitOfWork(SampleContext context)
        {
            Db = context;
        }

        public bool Commit()
        {
            return Db.SaveChanges() > 0;
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}

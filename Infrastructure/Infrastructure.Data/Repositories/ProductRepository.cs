using Domain.Models.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public override IQueryable<Product> Get()
        {
            return UnitOfWork.Db<Product>();
        }
    }
}

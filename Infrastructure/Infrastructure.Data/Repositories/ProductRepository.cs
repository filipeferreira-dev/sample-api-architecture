using Domain.Models.Entities;
using Domain.Services.Interfaces.Repository;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SampleContext context) : base(context)
        {
        }

        public override IList<Product> Get()
        {
            return Db.Products.ToList();
        }

        public Task<Product> GetByIdAsync(long id)
        {
            return Db.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        }
    }
}

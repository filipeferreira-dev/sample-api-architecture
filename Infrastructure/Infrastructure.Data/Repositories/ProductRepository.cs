using Domain.Models.Entities;
using Domain.Services.Interfaces.Repository;
using Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public SampleContext Db { get; private set; }


        public ProductRepository(SampleContext context) //: base(unitOfWork)
        {
            Db = context;
        }

        public override IList<Product> Get()
        {
            return Db.Products.ToList();
        }
    }
}

using Domain.Models.Entities;
using System.Collections.Generic;

namespace Domain.Services.Interfaces.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetById(long id);
    }
}

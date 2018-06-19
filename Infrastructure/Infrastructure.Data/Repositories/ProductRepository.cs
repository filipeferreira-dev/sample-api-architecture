﻿using Domain.Models.Entities;
using Domain.Services.Interfaces.Repository;
using Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

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

        public Product GetById(long id)
        {
            return Db.Products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}

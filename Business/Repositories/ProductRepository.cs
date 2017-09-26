using System;
using Business.Contexts;
using Business.Entities;

namespace Business.Repositories
{
    public class ProductRepository:GenericRepository<Product>
    {
        public ProductRepository():base(new GenericContext())
        {
            
        }

    }
}

using System;
using Business.Entities;

namespace Business.Services
{
    public class ProductService:GenericService<Product>
    {
        public ProductService():base(new Repositories.ProductRepository())
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMicroservice.Models;

namespace ProductMicroservice.Persistance.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context) => _context = context;

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

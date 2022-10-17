using Mediator_design_pattern_product.Data;
using Mediator_design_pattern_product.Model;
using Mediator_design_pattern_product.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> CreateProductAsync(Product product)
        {
            _db.Product.Add(product);
            return await SaveAsync();
        }

        public async Task<bool> DeleteProductAsync(Product product)
        {
            _db.Product.Remove(product);
            return await SaveAsync();
        }

        public async Task<ICollection<Product>> GetAllProductsAsync()
        {
            return await _db.Product.OrderBy(a => a.Title).AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _db.Product.Where(a => a.Id == productId).AsNoTracking().SingleOrDefaultAsync();
        }

        public async Task<bool> ProductExistsAsync(int id)
        {
            return await _db.Product.AsNoTracking().AnyAsync(a => a.Id == id);
        }

        public async Task<bool> ProductExistsAsync(string title)
        {
            return await _db.Product.AsNoTracking().AnyAsync(a => a.Title.ToLower().Trim() == title.ToLower().Trim());
        }

        public async Task<bool> SaveAsync()
        {
            return await _db.SaveChangesAsync() >= 0 ? true : false;
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            _db.Product.Update(product);
            _db.Entry(product).State = EntityState.Modified;
            return await SaveAsync();
        }
    }
}

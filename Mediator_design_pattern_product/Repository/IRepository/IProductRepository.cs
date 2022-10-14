using Mediator_design_pattern_product.Model;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Repository.IRepository
{
    public interface IProductRepository
    {
        Task<ICollection<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<bool> ProductExistsAsync(int id);
        Task<bool> ProductExistsAsync(string title);
        Task<bool> CreateProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(Product product);
        Task<bool> SaveAsync();
    }
}

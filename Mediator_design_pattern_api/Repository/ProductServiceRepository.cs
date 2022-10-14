using Mediator_design_pattern_api.Models;
using Mediator_design_pattern_api.Repository.IRepository;

namespace Mediator_design_pattern_api.Repository
{
    public class ProductServiceRepository : IProductServiceRepository
    {
        public Product GetProduct(int id)
        {
            // In real time fetch result from database
            return new Product() { Id = id, Name = "Hp Laptop", Price = 800 };
        }
    }
}

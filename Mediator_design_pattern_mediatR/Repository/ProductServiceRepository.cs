using Mediator_design_pattern_mediatR.Model;
using Mediator_design_pattern_mediatR.Repository.IRepository;

namespace Mediator_design_pattern_mediatR.Repository
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

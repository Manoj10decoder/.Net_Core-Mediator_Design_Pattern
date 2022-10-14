using Mediator_design_pattern_Code_Imp.Model;
using Mediator_design_pattern_Code_Imp.Repository.IRepository;

namespace Mediator_design_pattern_Code_Imp.Repository
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

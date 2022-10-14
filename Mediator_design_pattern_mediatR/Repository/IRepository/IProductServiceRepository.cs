using Mediator_design_pattern_mediatR.Model;

namespace Mediator_design_pattern_mediatR.Repository.IRepository
{
    public interface IProductServiceRepository
    {
        Product GetProduct(int id);
    }
}

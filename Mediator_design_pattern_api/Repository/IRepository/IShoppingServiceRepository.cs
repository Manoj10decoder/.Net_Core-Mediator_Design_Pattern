using Mediator_design_pattern_api.Models;

namespace Mediator_design_pattern_api.Repository.IRepository
{
    public interface IShoppingServiceRepository
    {
        void AddToBasket(Product product);
    }
}

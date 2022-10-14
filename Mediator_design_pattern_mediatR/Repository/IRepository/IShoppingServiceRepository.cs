using Mediator_design_pattern_mediatR.Model;

namespace Mediator_design_pattern_mediatR.Repository.IRepository
{
    public interface IShoppingServiceRepository
    {
        void AddToBasket(Product product);
    }
}

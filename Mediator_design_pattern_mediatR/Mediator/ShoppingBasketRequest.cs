using MediatR;

namespace Mediator_design_pattern_mediatR.Mediator
{
    public class ShoppingBasketRequest : IRequest
    {
        public int ProductId { get; set; }
    }
}

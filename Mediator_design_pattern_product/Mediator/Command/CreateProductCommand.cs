using Mediator_design_pattern_product.Model.Dto;
using MediatR;

namespace Mediator_design_pattern_product.Mediator.Command
{
    public class CreateProductCommand : IRequest<bool>
    {
        public CreateProductDto _createProduct;
        public CreateProductCommand(CreateProductDto createProduct)
        {
            _createProduct = createProduct;
        }
    }
}

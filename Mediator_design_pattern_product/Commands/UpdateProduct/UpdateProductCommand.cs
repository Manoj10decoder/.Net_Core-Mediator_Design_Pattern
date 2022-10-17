using Mediator_design_pattern_product.Model;
using Mediator_design_pattern_product.Model.Dto;
using MediatR;

namespace Mediator_design_pattern_product.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public UpdateProductDto _updateProduct;
        public UpdateProductCommand(UpdateProductDto updateProduct)
        {
            _updateProduct = updateProduct;
        }
    }
}

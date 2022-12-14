using Mediator_design_pattern_product.Model.Dto;
using MediatR;

namespace Mediator_design_pattern_product.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public ProductDto productDto;

        public DeleteProductCommand(ProductDto productDto)
        {
            this.productDto = productDto;
        }
    }
}

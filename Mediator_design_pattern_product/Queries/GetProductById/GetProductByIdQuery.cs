using Mediator_design_pattern_product.Model.Dto;
using MediatR;

namespace Mediator_design_pattern_product.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ProductDto>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}

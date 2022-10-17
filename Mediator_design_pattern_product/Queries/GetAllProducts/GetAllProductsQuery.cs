using Mediator_design_pattern_product.Model;
using Mediator_design_pattern_product.Model.Dto;
using MediatR;
using System.Collections;
using System.Collections.Generic;

namespace Mediator_design_pattern_product.Queries.GetAllProducts
{
    // TRequest<TResponse> - TResponse is the type of data that will be returned by Query
    public class GetAllProductsQuery : IRequest<ICollection<ProductDto>>
    {
    }
}

using AutoMapper;
using Mediator_design_pattern_product.Model;
using Mediator_design_pattern_product.Model.Dto;
using System;

namespace Mediator_design_pattern_product.ProductMapper
{
    public class ProductMappings : Profile
    {
        public ProductMappings()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}

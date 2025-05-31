using AutoMapper;
using MyBusiness_DB.DataTransferObjects;
using MyBusiness_DB.Models;

namespace MyBusiness_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<ProductByOrder, ProductByOrderDto>().ReverseMap();
        }
    }
}
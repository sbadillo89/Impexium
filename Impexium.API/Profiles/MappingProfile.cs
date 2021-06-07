using AutoMapper;
using Impexium.API.DTO;
using Impexium.API.Models;

namespace Impexium.API.Profiles
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<ProductCreateDto, Product>();
        }
    }
}

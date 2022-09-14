using AutoMapper;

using PPShowcase.Data.Entity;
using PPShowcase.Models;

namespace PPShowcase.MappingProfiles
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            AllowNullCollections = true;
            CreateMap<Product, ProductDto>()
                //.ForMember(dest => dest.Category, opt => opt.Ignore())
                .ReverseMap();
                //.ForMember(dest=>dest.CategoryId,opt=>opt.MapFrom(src => src.Category.Id));
            CreateMap<Category,CategoryDto>().ReverseMap();
        }

        
    }
}

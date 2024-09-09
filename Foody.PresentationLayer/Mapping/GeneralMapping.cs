using AutoMapper;
using Foody.DtoLayer.Dtos.CategoryDtos;
using Foody.EntityLayer.Concrete;

namespace Foody.PresentationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
        }
    }
}

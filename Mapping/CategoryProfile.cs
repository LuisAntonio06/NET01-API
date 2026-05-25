using System;
using AutoMapper;
using curso_dotNET.Models.Dtos;

namespace curso_dotNET.Mapping;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category,CategoryDto>().ReverseMap();
        CreateMap<Category,CreateCategoryDto>().ReverseMap();

    }
}

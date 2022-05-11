using AutoMapper;
using ProductApp.Application.Commands;
using ProductApp.Application.Common.Responses;
using ProductApp.Domain.Entities;

namespace ProductApp.Application.Common.Mappings;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<CreateCategoryCommand, Category>();
        CreateMap<Category, CategoryResponse>();
    }
}

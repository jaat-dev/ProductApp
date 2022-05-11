using AutoMapper;
using MediatR;
using ProductApp.Application.Commands;
using ProductApp.Application.Common.Responses;
using ProductApp.Domain.Entities;
using ProductApp.Domain.Repositories;

namespace ProductApp.Application.EventHandlers.CommandHandlers;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CategoryResponse>
{
    private readonly ICategoryRepository _category;
    private readonly IMapper _mapper;

    public CreateCategoryCommandHandler(
        ICategoryRepository category,
        IMapper mapper)
    {
        _category = category;
        _mapper = mapper;
    }

    public async Task<CategoryResponse> Handle(
        CreateCategoryCommand request,
        CancellationToken cancellationToken)
    {
        Category categoryEntitiy = _mapper.Map<Category>(request);
        if (categoryEntitiy == null)
            throw new ApplicationException("Issue with mapper");

        Category category = await _category.AddAsync(categoryEntitiy);
        return _mapper.Map<CategoryResponse>(category);
    }
}
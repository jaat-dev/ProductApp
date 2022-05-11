using MediatR;
using ProductApp.Application.Common.Responses;

namespace ProductApp.Application.Commands
{
    public class CreateCategoryCommand : IRequest<CategoryResponse>
    {
        public string Description { get; set; }
    }
}

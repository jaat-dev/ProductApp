using FluentValidation;

namespace ProductApp.Application.Commands;

public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(c=>c.Description)
            .MaximumLength(300)
            .NotEmpty();
    }
}

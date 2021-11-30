using FluentValidation;

namespace DotNetPrototypes.Core.UseCases.Cooler.AddCooler;

public class AddCoolerRequestValidator : CustomAbstractValidator<AddCoolerRequest>
{
    public AddCoolerRequestValidator()
    {
        RuleFor(x => x.Name).Length(3, 60);
        RuleFor(x => x.Rpm).GreaterThan(0);
    }
}

using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c=>c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c=>c.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThanOrEqualTo(1);
        }
    }
}

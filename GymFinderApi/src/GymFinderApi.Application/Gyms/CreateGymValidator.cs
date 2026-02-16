namespace GymFinderApi.Application.Gyms
{
    using FluentValidation;
    using GymFinderApi.Contracts.GymDto;

    public class CreateGymValidator : AbstractValidator<CreateGymDTO>
    {
        public CreateGymValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(500).WithMessage("Name cannot exceed 100 characters.");
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(2000).WithMessage("Description cannot exceed 500 characters.");
            RuleFor(x => x.City)
                .NotEmpty().WithMessage("City is required.")
                .MaximumLength(50).WithMessage("City cannot exceed 50 characters.");
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address is required.")
                .MaximumLength(200).WithMessage("Address cannot exceed 200 characters.");
            RuleFor(x => x.Schedule)
                .NotEmpty().WithMessage("Schedule is required.")
                .MaximumLength(200).WithMessage("Schedule cannot exceed 200 characters.");
        }
    }
}

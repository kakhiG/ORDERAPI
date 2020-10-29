using FluentValidation;
using OrderApi.Models;


namespace OrderApi.Validators
{
    public class OrderModelValidator : AbstractValidator<OrderModel>
    {
        public OrderModelValidator()
        {
            RuleFor(x => x.CustomerName)
                .NotNull()
                .WithMessage("The customer name must be at least 2 character long");
            RuleFor(x => x.CustomerName)
                .MinimumLength(2).WithMessage("The customer name must be at least 2 character long");
        }
    }
}
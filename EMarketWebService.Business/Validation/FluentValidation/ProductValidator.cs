using EMarketWebService.Entities.Concretes;
using FluentValidation;

namespace EMarketWebService.Business.Validation.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.CategoryId).GreaterThan(0);
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(3);
            RuleFor(p => p.ProductName).Must(NotStartWith);
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.UnitsInStock).GreaterThan(0);
        }

        private bool NotStartWith(string productName)
        {
            return !(productName.StartsWith("ı")
                     | productName.StartsWith("I")
                     | productName.StartsWith("ğ")
                     | productName.StartsWith("Ğ"));
        }
    }
}

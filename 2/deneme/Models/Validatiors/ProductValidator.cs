using FluentValidation;

namespace deneme.Models.Validatiors
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator() 
        {
            RuleFor(x => x.Email).NotNull().WithMessage("E mail boş olamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("E mail formatında değil");

            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("Product Name boş olamaz");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("max 100 karakter");
        }
    }
}

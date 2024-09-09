using FluentValidation;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.ValidationRules.CategoryRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Lütfen Boş Alan Bırakmayınız");
        }
    }
}

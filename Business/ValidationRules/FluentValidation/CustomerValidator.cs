using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CustomerValidator: AbstractValidator<Customers>
   {
        public CustomerValidator()
        {
            RuleFor(p => p.CompanyName).NotEmpty();
        }
   }
}

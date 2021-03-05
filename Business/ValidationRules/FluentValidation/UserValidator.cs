using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class UserValidator: AbstractValidator<Users>
   {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(4);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(4);
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).GreaterThan(6);
        }
   }
}

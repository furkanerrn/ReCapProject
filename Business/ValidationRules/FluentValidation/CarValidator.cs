using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.DailyPrice).NotEmpty().WithMessage("Ücret giriniz");
            RuleFor(p => p.DailyPrice).GreaterThan(0).WithMessage("Ücret 0 Tl'den büyük olmalı");
            RuleFor(p => p.BrandId).NotEmpty().WithMessage("Marka Id boş bırakılamaz");
            RuleFor(p => p.Description).MinimumLength(10).WithMessage("Tanım 10 harften uzun olmalı");
            RuleFor(p => p.ModelYear).LessThan(2020).WithMessage("İleri bir tarih girmeyiniz");
            RuleFor(p => p.ColorId).NotEmpty().WithMessage("Renk Id boş bırakılamaz.");

        }
    }
}

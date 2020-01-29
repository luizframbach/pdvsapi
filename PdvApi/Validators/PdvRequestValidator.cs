﻿using FluentValidation;
using PdvApi.Models;

namespace PdvApi.Validators
{
    public class PdvRequestValidator : AbstractValidator<Pdv>
    {
        public PdvRequestValidator()
        {
            RuleFor(c => c.TradingName).NotNull().NotEmpty();
            RuleFor(c => c.OwnerName).NotNull().NotEmpty();
            RuleFor(c => c.Document).NotNull().NotEmpty();
            RuleFor(c => c.Document).Length(14);
            RuleFor(c => c.CoverageArea).NotNull();
            RuleFor(c => c.Address).NotNull();
        }
    }
}
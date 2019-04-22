﻿using AgencyBanking.Entities;
using CashWithdrawal.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashWithdrawalPlusChrg.Validators
{
    public class CashWithDrawalRequestValidator : AbstractValidator<Request>
    {
        private readonly AppSettings settings;
        public CashWithDrawalRequestValidator(AppSettings _settings)
        {
            settings = _settings;
            RuleFor(req => req.debitAccount)
                  .NotNull()
                  .NotEmpty()
                  .MaximumLength(20);
            RuleFor(req => req.amount)
                    .NotNull()
                    .NotEmpty()
                    .GreaterThan(0);

            RuleFor(req => req.narration)
                    .NotNull()
                    .NotEmpty()
                    .MaximumLength(100);

            RuleFor(req => req.chargeRate)
                   .NotNull()
                   .NotEmpty()
                   .GreaterThan(0);

            RuleFor(req => req.branchCode)
                  .NotNull()
                  .NotEmpty()
                  .MaximumLength(100);

            RuleFor(req => req.userName)
                  .NotNull()
                  .NotEmpty()
                  .MaximumLength(100);

            RuleFor(req => req.requestId)
                  .NotNull()
                  .NotEmpty()
                  .MaximumLength(100)
                  .SetValidator(new RequestIdValidator(settings));

            RuleFor(req => req.creditAccount)
                   .NotNull()
                   .NotEmpty()
                   .MaximumLength(20);

            RuleFor(req => req.currency)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .SetValidator(new CurrencyEnumValidator());
        }
    }
}

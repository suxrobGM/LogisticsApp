﻿using FluentValidation;

namespace Logistics.Application.Queries;

internal sealed class GetEmployeesValidator : AbstractValidator<GetEmployeesQuery>
{
    public GetEmployeesValidator()
    {
        RuleFor(i => i.Page)
            .GreaterThanOrEqualTo(0);
        
        RuleFor(i => i.PageSize)
            .GreaterThanOrEqualTo(1);
    }
}

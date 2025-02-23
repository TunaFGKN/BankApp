using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FluentValidation.Results;

namespace BankingCreditSystem.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class ValidationProblemDetails : ProblemDetails
    {
        public IEnumerable<ValidationFailure> Errors { get; init; }

        public ValidationProblemDetails(IEnumerable<ValidationFailure> errors)
        {
            Title = "Validation error(s)";
            Detail = "One or more validation errors occurred.";
            Errors = errors;
            Status = StatusCodes.Status400BadRequest;
            Type = "https://example.com/probs/validation";
        }
    }
} 
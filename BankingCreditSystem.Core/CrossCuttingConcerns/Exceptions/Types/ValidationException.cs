using System;
using System.Collections.Generic;
using FluentValidation.Results;

public class ValidationException : Exception
{
    public IEnumerable<ValidationFailure> Errors { get; set; }

    public ValidationException(IEnumerable<ValidationFailure> errors) : base("Validation error(s)")
    {
        Errors = errors;
    }
}   

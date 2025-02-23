using BankingCreditSystem.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using FluentValidation.Results;

public class HttpExceptionHandler : ExceptionHandler
{
    private readonly HttpContext _context;

    public HttpExceptionHandler(HttpContext context)
    {
        _context = context;
    }

    protected override Task HandleException(BusinessException businessException)
    {
        var details = new BusinessProblemDetails(businessException.Message);
        _context.Response.StatusCode = details.Status.Value;
        return JsonSerializer.SerializeAsync(_context.Response.Body, details); // Use JsonSerializer.SerializeAsync
    }

    protected override Task HandleException(ValidationException validationException)
    {
        var details = new BankingCreditSystem.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails.ValidationProblemDetails(validationException.Errors);
        _context.Response.StatusCode = details.Status.Value;
        return JsonSerializer.SerializeAsync(_context.Response.Body, details); // Use JsonSerializer.SerializeAsync
    }

    protected override Task HandleException(Exception exception)
    {
        var details = new ProblemDetails
        {
            Status = StatusCodes.Status500InternalServerError,
            Type = "https://example.com/probs/internal",
            Title = "Internal server error",
            Detail = exception.Message
        };
        _context.Response.StatusCode = details.Status.Value;
        return JsonSerializer.SerializeAsync(_context.Response.Body, details); // Use JsonSerializer.SerializeAsync
    }
}

public abstract class ExceptionHandler
{
    public Task HandleExceptionAsync(Exception exception)
    {
        if (exception is BusinessException businessException)
            return HandleException(businessException);
        if (exception is ValidationException validationException)
            return HandleException(validationException);
        // Add other exception types as needed
        return HandleException(exception);
    }

    protected abstract Task HandleException(BusinessException businessException);
    protected abstract Task HandleException(ValidationException validationException);
    protected abstract Task HandleException(Exception exception);
}
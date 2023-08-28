using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class ValidationProblemDetails : ProblemDetails
{
    public IEnumerable<ValidationExceptionModel> Errors { get; set; }

    public ValidationProblemDetails(IEnumerable<ValidationExceptionModel> errors)
    {
        Title = "Validations error(s)";
        Detail = "One or mpre validation errors occured";
        Errors = errors;
        Status = StatusCodes.Status400BadRequest;
        Type = "https://example.com/probs/validation";
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ProblemDetailsExtensions
{
    public static string AsJosn<TProblemDetail>(this TProblemDetail details) where TProblemDetail : ProblemDetails => JsonSerializer.Serialize(details);
}

using Microsoft.AspNetCore.Mvc;
using SchoolManagement.SharedKernel.Primitives;

namespace SchoolManagement.Api.Extensions;

public static class ErrorExtensions
{
    public static IActionResult ToProblem(this Error error)
    {
        var status = error.Type switch
        {
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            _ => StatusCodes.Status500InternalServerError
        };

        var problem = new ProblemDetails
        {
            Status = status,
            Title = error.Code,
            Detail = error.Message
        };
        return new ObjectResult(problem) { StatusCode = status };
    }
}
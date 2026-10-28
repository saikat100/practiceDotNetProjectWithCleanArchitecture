using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;
using SchoolManagement.Application.Features.Teachers.Queries.GetAllTeachers;

namespace SchoolManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeachersController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateTeacherCommand command, CancellationToken cancellationToken)
    {
        var result = await sender.Send(command, cancellationToken);
        return result.IsSuccess ? Ok(new {id = result.Value}) : result.Error.ToProblem();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        return Ok(await sender.Send(new GetAllTeachersQuery(), cancellationToken));
    }
}

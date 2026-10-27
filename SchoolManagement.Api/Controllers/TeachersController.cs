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
        var id = await sender.Send(command, cancellationToken);
        var fullName = $"{command.FirstName} {command.LastName}";

        return Ok(new { Id = id, FullName = fullName });
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        return Ok(await sender.Send(new GetAllTeachersQuery(), cancellationToken));
    }
}

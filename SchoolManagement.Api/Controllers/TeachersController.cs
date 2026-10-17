using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Features.Teachers;
using SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;

namespace SchoolManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TeachersController(CreateTeacherCommandHandler createTeacherCommandHandler) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Create(CreateTeacherCommand command, CancellationToken cancellationToken)
    {
        var id = await createTeacherCommandHandler.Handle(command, cancellationToken);
        var fullName = $"{command.FirstName} {command.LastName}";

        return Ok(new { Id = id, FullName = fullName });
    }


    [HttpGet]
    public IActionResult Get()
    {
        return Ok(TeacherStore.Teachers);
    }
}

using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;
using SchoolManagement.Application.Features.Teachers.Queries.GetAllTeachers;


namespace SchoolManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TeachersController(
    CreateTeacherCommandHandler createTeacher,
    GetAllTeacherQueryHandler getAllTeachers) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Create(CreateTeacherCommand command, CancellationToken cancellationToken)
    {
        var id = await createTeacher.Handle(command, cancellationToken);
        var fullName = $"{command.FirstName} {command.LastName}";

        return Ok(new { Id = id, FullName = fullName });
    }


    [HttpGet]

    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        return Ok(await getAllTeachers.Handle(new GetAllTeachersQuery(), cancellationToken));
    }
}

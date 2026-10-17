namespace SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;

public class CreateTeacherCommandHandler
{
    public Task<Guid> Handle(CreateTeacherCommand command, CancellationToken cancellationToken)
    {
        var teacher = new TeacherResponse(
            Guid.NewGuid(),
            command.FirstName,
            command.LastName,
            $"{command.FirstName} {command.LastName}"
        );

        TeacherStore.Teachers.Add(teacher);

        return Task.FromResult(teacher.Id);
    }
}

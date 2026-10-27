using MediatR;
using SchoolManagement.Domain.Aggregate;
using SchoolManagement.Domain.Repositories;
namespace SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;

public class CreateTeacherCommandHandler(ITeacherRepository repository) : IRequestHandler<CreateTeacherCommand, Guid>
{
    public async Task<Guid> Handle(CreateTeacherCommand command, CancellationToken cancellationToken)
    {
        var teacher = TeacherAggregate.Create(command.FirstName, command.LastName);

        await repository.AddAsync(teacher, cancellationToken);
        return teacher.Id;
    }
}

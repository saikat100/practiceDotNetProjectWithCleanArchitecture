using MediatR;
using SchoolManagement.Domain.Aggregate;
using SchoolManagement.Domain.Repositories;
using SchoolManagement.SharedKernel.Primitives;
namespace SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;

public class CreateTeacherCommandHandler(ITeacherRepository repository) : IRequestHandler<CreateTeacherCommand, Result<Guid>>
{
    public async Task<Result<Guid>> Handle(CreateTeacherCommand command, CancellationToken cancellationToken)
    {
        var created = TeacherAggregate.Create(command.FirstName, command.LastName);
        if (created.IsFailure)
            return Result<Guid>.Failure(created.Error);

        var teacher = created.Value;

        await repository.AddAsync(teacher, cancellationToken);
        return Result<Guid>.Success(teacher.Id);
    }
}

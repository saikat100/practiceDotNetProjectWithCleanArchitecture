using MediatR;
namespace SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;
using SchoolManagement.SharedKernel.Primitives;

public sealed record CreateTeacherCommand(
    string FirstName,
    string LastName
    ) : IRequest<Result<Guid>>;

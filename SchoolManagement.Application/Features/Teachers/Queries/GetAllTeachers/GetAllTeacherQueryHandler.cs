using MediatR;
using SchoolManagement.Domain.Aggregate;
using SchoolManagement.Domain.Repositories;

namespace SchoolManagement.Application.Features.Teachers.Queries.GetAllTeachers;

public class GetAllTeachersQueryHandler(ITeacherRepository repository) : IRequestHandler<GetAllTeachersQuery, List<TeacherResponse>>
{
    public async Task<List<TeacherResponse>> Handle(GetAllTeachersQuery query, CancellationToken cancellationToken)
    {
        var teachers = await repository.GetAllAsync(cancellationToken);
        return teachers.Select(t => new TeacherResponse(t.Id, t.FirstName, t.LastName, t.FullName)).ToList();
    }
}

using SchoolManagement.Domain.Repositories;

namespace SchoolManagement.Application.Features.Teachers.Queries.GetAllTeachers;

public class GetAllTeacherQueryHandler(ITeacherRepository repository)
{
    public async Task<List<TeacherResponse>> Handle(GetAllTeachersQuery query, CancellationToken cancellationToken)
    {
        var teachers = await repository.GetAllAsync(cancellationToken);
        return teachers.Select(t => new TeacherResponse(t.Id, t.FirstName, t.LastName, t.FullName)).ToList();
    }
}

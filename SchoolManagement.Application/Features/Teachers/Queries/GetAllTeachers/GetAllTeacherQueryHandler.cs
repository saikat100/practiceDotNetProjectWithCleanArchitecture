using SchoolManagement.Domain.Aggregate;

namespace SchoolManagement.Application.Features.Teachers.Queries.GetAllTeachers;

public class GetAllTeacherQueryHandler
{
    public Task<List<TeacherResponse>> Handle(GetAllTeachersQuery query, CancellationToken cancellationToken)
    {
        var teachers = TeacherStore.Teachers.Select(t => new TeacherResponse(t.Id, t.FirstName, t.LastName, t.FullName)).ToList();
        return Task.FromResult(teachers);
    }
}

namespace SchoolManagement.Application.Features.Teachers
{
    public sealed record TeacherResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string FullName
    );
}
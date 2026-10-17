namespace SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;

public sealed record CreateTeacherCommand(
    string FirstName,
    string LastName
);

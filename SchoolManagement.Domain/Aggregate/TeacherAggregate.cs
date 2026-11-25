using SchoolManagement.SharedKernel.Primitives;
namespace SchoolManagement.Domain.Aggregate;

public class TeacherAggregate
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}";

    private TeacherAggregate(){}

    public static Result<TeacherAggregate> Create(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            return Result<TeacherAggregate>.Failure(Error.Validation("Teacher.FirstNameRequired", "First name is required."));

        if (string.IsNullOrWhiteSpace(lastName))
            return Result<TeacherAggregate>.Failure(Error.Validation("Teacher.LastNameRequired", "Last name is required."));

        var teacher = new TeacherAggregate{
            Id = Guid.NewGuid(),
            FirstName = firstName.Trim(),
            LastName = lastName.Trim()
        };
        return Result<TeacherAggregate>.Success(teacher);
    }
}

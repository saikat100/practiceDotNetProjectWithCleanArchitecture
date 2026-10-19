namespace SchoolManagement.Domain.Aggregate;

public class TeacherAggregate
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}";

    private TeacherAggregate(){}

    public static TeacherAggregate Create(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("First name is required.", nameof(firstName));

        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("Last name is required.", nameof(lastName));

        var teacher = new TeacherAggregate{
            Id = Guid.NewGuid(),
            FirstName = firstName.Trim(),
            LastName = lastName.Trim()
        };
        return teacher;
    }
}

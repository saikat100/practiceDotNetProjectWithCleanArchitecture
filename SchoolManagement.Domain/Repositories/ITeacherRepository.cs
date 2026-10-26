using SchoolManagement.Domain.Aggregate;

namespace SchoolManagement.Domain.Repositories;

public interface ITeacherRepository
{
    Task AddAsync(TeacherAggregate teacher, CancellationToken cancellationToken = default);
    Task<List<TeacherAggregate>> GetAllAsync(CancellationToken cancellationToken = default);
}
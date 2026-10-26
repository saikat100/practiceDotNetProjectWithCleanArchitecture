using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Aggregate;    
using SchoolManagement.Domain.Repositories;
using SchoolManagement.Infrastructure.Persistence;

namespace SchoolManagement.Infrastructure.Repositories;

public class TeacherRepository(SchoolDbContext db) : ITeacherRepository
{
    public async Task AddAsync(TeacherAggregate teacher, CancellationToken cancellationToken = default)
    {
        db.Teachers.Add(teacher);
        await db.SaveChangesAsync(cancellationToken);
    }

    public Task<List<TeacherAggregate>> GetAllAsync(CancellationToken cancellationToken = default)
    => db.Teachers.AsNoTracking().ToListAsync(cancellationToken);
}
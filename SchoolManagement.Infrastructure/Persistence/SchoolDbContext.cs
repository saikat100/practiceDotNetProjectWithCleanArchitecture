using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Aggregate;

namespace SchoolManagement.Infrastructure.Persistence;

public class SchoolDbContext(DbContextOptions<SchoolDbContext> options) : DbContext(options)
{
    public DbSet<TeacherAggregate> Teachers => Set<TeacherAggregate>();
}
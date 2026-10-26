using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Repositories;
using SchoolManagement.Infrastructure.Persistence;
using SchoolManagement.Infrastructure.Repositories;

namespace SchoolManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<SchoolDbContext>(options =>
            options.UseInMemoryDatabase("SchoolDb"));
            services.AddScoped<ITeacherRepository, TeacherRepository>();
        return services;
    }
}
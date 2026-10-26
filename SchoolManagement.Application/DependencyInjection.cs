using Microsoft.Extensions.DependencyInjection;
using SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;
using SchoolManagement.Application.Features.Teachers.Queries.GetAllTeachers;

namespace SchoolManagement.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<CreateTeacherCommandHandler>();
        services.AddScoped<GetAllTeacherQueryHandler>();

        return services;
    }
}

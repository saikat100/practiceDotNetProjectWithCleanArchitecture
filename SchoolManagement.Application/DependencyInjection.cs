using Microsoft.Extensions.DependencyInjection;
using SchoolManagement.Application.Features.Teachers.Commands.CreateTeacher;

namespace SchoolManagement.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<CreateTeacherCommandHandler>();

        return services;
    }
}

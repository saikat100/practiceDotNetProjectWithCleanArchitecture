using MediatR;
using SchoolManagement.Domain.Aggregate;
using SchoolManagement.Domain.Repositories;
namespace SchoolManagement.Application.Features.Teachers.Queries.GetAllTeachers;

public sealed record GetAllTeachersQuery() : IRequest<List<TeacherResponse>>;

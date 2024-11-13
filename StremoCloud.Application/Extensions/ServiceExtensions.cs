using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StremoCloud.Application.Features.Behaviours;
using StremoCloud.Infrastructure.Data;
using System.Reflection;

namespace StremoCloud.Application.Extensions;

public static class ServiceExtensions
{
    public static void AddApplicationLayer(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        services.AddScoped<IDataContext, DataContext>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
    }
}

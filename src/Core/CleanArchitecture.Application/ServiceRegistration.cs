using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using CleanArchitecture.Application.Behaviours;
using FluentValidation;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();

            services.AddAutoMapper(assm);
            services.AddValidatorsFromAssembly(assm);
            services.AddMediatR(assm);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddTransient(typeof(IRequestPreProcessor<>), typeof(LoggingBehavior<>));
        }
    }
}

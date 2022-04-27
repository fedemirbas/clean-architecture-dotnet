using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CleanArchitecture.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.IncludeXmlComments(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "CleanArchitecture.WebApi.xml"));
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "CleanArchitecture WebApi",
                    Description = "This Api will be responsible for orders.",
                    Contact = new OpenApiContact
                    {
                        Name = "fedemirbas",
                        Email = "f.emredemirbas@gmail.com",
                        Url = new Uri("https://google.com"),
                    }
                });
                //c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.OperationFilter<AcceptedLanguageHeader>();
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    Description = "Input your Bearer token in this format - Bearer {your token here} to access this API",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer",
                            },
                            Scheme = "Bearer",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        }, new List<string>()
                    },
                });
            });
        }

        public class AcceptedLanguageHeader : IOperationFilter
        {
            public void Apply(OpenApiOperation operation, OperationFilterContext context)
            {
                operation.Parameters ??= new List<OpenApiParameter>();

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "Accept-Language",
                    Description = "Accepted language value (en-US, tr-TR)",
                    In = ParameterLocation.Header,
                    Schema = new OpenApiSchema()
                    {
                        Type = "string",
                        Default = new OpenApiString("en-US")
                    },
                    Required = true,
                });
            }
        }
    }
}

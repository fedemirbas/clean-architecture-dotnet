using CleanArchitecture.WebApi.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CleanArchitecture.WebApi.Extensions
{
    public static class AppExtensions
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CleanArchitecture.WebApi");
            });
        }
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }

        public static void UseLocalizationExtension(this IApplicationBuilder app)
        {
            var supportedCultures = new[] { "en-US", "tr-TR" };
            app.UseRequestLocalization(options =>
            {
                options.SetDefaultCulture(supportedCultures[0]);
                options.AddSupportedCultures(supportedCultures);
                options.AddSupportedUICultures(supportedCultures);
                options.ApplyCurrentCultureToResponseHeaders = true;
            });
        }
    }
}

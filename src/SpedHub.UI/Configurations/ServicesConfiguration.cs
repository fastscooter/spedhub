using SpedHub.Data.Repositories;
using SpedHub.Data.Text;
using SpedHub.Domain.Repositories;
using SpedHub.Domain.Supervisor;
using SpedHub.Domain.Text;

namespace SpedHub.UI.Configurations
{
    public static class ServicesConfiguration
    {
        public static void ConfigureTextGenerationSerivce(this IServiceCollection services)
        {
            services.AddScoped<ISpedHubTextGenerationService, SpedHubTextGenerationService>();
        }
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>()
                .AddScoped<IDisabilityRepository, DisabilityRepository>()
                .AddScoped<IAreaRepository, AreaRepository>()
                .AddScoped<IGoalRepository, GoalRepository>()
                .AddScoped<IServiceRepository, ServiceRepository>()
                .AddScoped<IAccommodationRepository, AccommodationRepository>();
        }

        public static void ConfigureSupervisor(this IServiceCollection services)
        {
            services.AddScoped<ISpedHubSupervisor, SpedHubSupervisor>();
        }

        public static void AddAPILogging(this IServiceCollection services)
        {
            services.AddLogging(builder => builder
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information)
            );
        }

        public static void AddCaching(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddResponseCaching();
        }

        public static void AddCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

    }
}

using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SpedHub.Data;
using SpedHub.Domain.DbInfo;

namespace SpedHub.UI.Configurations
{
    public static class ConfigureConnections
    {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services)
        {
            var connection = "Server=.;Database=SpedHubDB;Trusted_Connection=True;TrustServerCertificate=True";

            services.AddDbContext<SpedHubDbContext>(options => options.UseSqlServer(connection));

            services.AddSingleton(new SqlConnection(connection));

            services.AddSingleton(new DbInfo(connection));

            return services;
        }
    }
}

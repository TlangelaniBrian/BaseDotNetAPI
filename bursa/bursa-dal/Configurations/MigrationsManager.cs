using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace bursa_dal.Configurations
{
    public static class MigrationsManager
    {
        public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<bursaContext>();
            try
            {
                
            }
            catch (Exception)
            {
                //NOTE: EXCEPTION HANDING AND ERROR LOGING IS REQUIRED
            }
            return app;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Kupri4.IMS.Plugins.EFCore
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddImsDependendencies(this IServiceCollection services)
        {
            services.AddDbContext<IMSDbContext>(opt =>
            {
                opt.UseSqlite("Data Source=Kupri4.Ims.db");
            });

            return services;
        }
    }
}

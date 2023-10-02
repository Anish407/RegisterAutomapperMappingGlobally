using RegisterAutomapperMappingGlobally;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AutoMapperExtensions
    {
        public static IServiceCollection RegisterAutoMapperMapping(this IServiceCollection services)
        {
           
            services.AddAutoMapper(typeof(AutoMapperProfiles));

            
            return services;
        }
    }
}

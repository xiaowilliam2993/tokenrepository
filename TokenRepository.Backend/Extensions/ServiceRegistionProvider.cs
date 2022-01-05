using Microsoft.Extensions.DependencyInjection;
using System;
using TokenRepository.Backend.Services;
using TokenRepository.Backend.Services.Implement;

namespace TokenRepository.Backend.Extensions
{
    public static class ServiceRegistionProvider
    {
        public static void RegistService(this IServiceCollection services)
        {
            #region Parameter validate
            if (services == null) throw new ArgumentNullException(nameof(services));
            #endregion

            services.AddScoped<ITokenBasisService, TokenBasisServiceImpl>();
        }
    }
}

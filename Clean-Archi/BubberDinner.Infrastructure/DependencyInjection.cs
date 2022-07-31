using BubberDinner.Infrastructure.Auth;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubberDinner.Application.Common.Interfaces.Auth;
using BubberDinner.Application.Common.Interfaces.Persistence;
using BubberDinner.Infrastructure.Persistence;

namespace BubberDinner.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services , ConfigurationManager configuration)
        {
            services.Configure<JWTSettings>(configuration.GetSection(JWTSettings.SectionName));
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<IUserRepo, UserRepo>();
            return services;
        }
    }
}

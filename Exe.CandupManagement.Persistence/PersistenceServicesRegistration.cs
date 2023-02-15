using Exe.CandupManagement.Application.Contracts.Identity;
using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Application.Contracts.Persistence.Generic;
using Exe.CandupManagement.Application.Models.Identity;
using Exe.CandupManagement.Domain.Entities;
using Exe.CandupManagement.Persistence.Repositories;
using Exe.CandupManagement.Persistence.Repositories.Generic;
using Exe.CandupManagement.Persistence.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            services.AddDbContext<CandupManagementDbContext>(ops =>
                ops.UseSqlServer(configuration.GetConnectionString("CandupManagementConnectionString"),
                b => b.MigrationsAssembly(typeof(CandupManagementDbContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<CandupManagementDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IAuthService, AuthService>();

            services.AddAuthentication(op =>
            {
                op.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                op.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidAudience = configuration["JwtSettings:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))
                };
            });

            return services;
        }
    }
}

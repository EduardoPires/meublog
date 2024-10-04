﻿using MeuBlog.Shared.Data;
using Microsoft.EntityFrameworkCore;

namespace MeuBlog.Api.Configurations
{
    public static class ContextConfiguration
    {
        public static WebApplicationBuilder AddContextConfiguration(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connectionString)
                );
            return builder;
        }
    }
}
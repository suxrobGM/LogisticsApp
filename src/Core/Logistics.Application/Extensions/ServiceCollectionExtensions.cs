﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Logistics.Application.Contracts.Services;
using Logistics.Application.Mappers;
using Logistics.Application.Options;
using Logistics.Application.Services;

namespace Logistics.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationLayer(
        this IServiceCollection services,
        IConfiguration configuration,
        string emailConfigSection = "EmailConfig")
    {
        services.AddAutoMapper(o =>
        {
            o.AddProfile<UserProfile>();
        });

        var emailSenderOptions = configuration.GetSection(emailConfigSection).Get<EmailSenderOptions>();

        services.AddMediatR(typeof(ServiceCollectionExtensions).Assembly);
        services.AddSingleton(emailSenderOptions);
        services.AddTransient<IEmailSender, EmailSender>();
        return services;
    }
}
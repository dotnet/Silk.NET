// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Bakery;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Sources;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Provides the <see cref="AddSilkTouch"/> method.
/// </summary>
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSilkTouch(
        this IServiceCollection services,
        IConfiguration config
    )
    {
        // References for our use of Microsoft.Extensions.Configuration/DependencyInjection:
        // - https://stevetalkscode.co.uk/using-iconfigureoptions
        // - https://stevetalkscode.co.uk/configuration-bridging-part-2
        // - https://andrewlock.net/configuring-named-options-using-iconfigurenamedoptions-and-configureall/
        // - https://andrewlock.net/how-to-register-a-service-with-multiple-interfaces-for-in-asp-net-core-di/
        // - https://discordapp.com/channels/143867839282020352/663803973119115264/1129546023388332075 (C# Discord)

        services.AddSingleton<ResponseFileHandler>();
        services.AddSingleton<FunctionTransformer>();
        services.AddSingleton<MSBuildModContext>(); // TODO
        services.AddSingleton<DefaultBakeStrategy>();
        services.AddSingleton<IBakeStrategy>(s => s.GetRequiredService<DefaultBakeStrategy>());
        services.TryAddSingleton<ICacheProvider, FileSystemCacheProvider>();
        services.AddSingleton<IInputSource, GitInputSource>();
        services.AddSingleton<IInputSource, NuGetInputSource>();
        services.AddSingleton<IFunctionTransformer, PtrRefTransformer>();
        services.AddSingleton<IFunctionTransformer, BoolTransformer>();
        services.AddSingleton<IFunctionTransformer, ArrayParameterTransformer>();
        services.TryAddSingleton<IInputResolver, UriBasedInputResolver>();
        if (OperatingSystem.IsWindows())
        {
            services.AddSingleton<IStdIncludeResolver, WindowsStdIncludeResolver>();
        }
        else if (OperatingSystem.IsMacOS())
        {
            services.AddSingleton<IStdIncludeResolver, MacOSStdIncludeResolver>();
        }
        else
        {
            services.AddSingleton<IStdIncludeResolver, UnixStdIncludeResolver>();
        }

        return services;
    }
}

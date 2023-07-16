
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SilkTouchX.Clang;
using SilkTouchX.Mods;

namespace SilkTouchX;

/// <summary>
/// Provides the <see cref="AddSilkTouch"/> method.
/// </summary>
public static class ServiceCollectionExtensions
{
    private static readonly MethodInfo _configure;
    static ServiceCollectionExtensions()
    {
        var cnf = typeof(OptionsConfigurationServiceCollectionExtensions)
            .GetMethod(nameof(OptionsConfigurationServiceCollectionExtensions.Configure),
                1,
                new[] { typeof(IServiceCollection), typeof(string), typeof(IConfiguration) });

        _configure = cnf ?? throw new TypeAccessException(
            $"Could not access the {nameof(OptionsConfigurationServiceCollectionExtensions.Configure)} method on " +
            nameof(OptionsConfigurationServiceCollectionExtensions));
    }

    /// <summary>
    /// Adds a <see cref="SilkTouchGenerator"/> singleton (and its dependencies) to the given
    /// <see cref="IServiceCollection"/>, using the root SilkTouch configuration provided.
    /// </summary>
    /// <remarks>
    /// It is expected that <see cref="OptionsServiceCollectionExtensions.AddOptions"/> and
    /// <see cref="LoggingServiceCollectionExtensions.AddLogging(IServiceCollection)"/> is used before this call.
    /// </remarks>
    /// <param name="services">
    /// The service collection to make the SilkTouch types available on. The service collection shall have the following
    /// types added to it:
    /// <list type="bullet">
    /// <item><description><see cref="ClangScraper"/></description></item>
    /// <item><description><see cref="ResponseFileHandler"/></description></item>
    /// <item><description><see cref="SilkTouchGenerator"/></description></item>
    /// <item><description>Mod implementations referenced in the configurations</description></item>
    /// <item>
    /// <description>
    /// <see cref="Microsoft.Extensions.Configuration"/> types for <see cref="SilkTouchConfiguration"/> and the
    /// <see cref="IMod.ConfigurationType"/>s for any of the loaded mods.
    /// </description>
    /// </item>
    /// </list>
    /// </param>
    /// <param name="config">
    /// A configuration structure that:
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Contains a root <c>"Jobs"</c> section, representing a dictionary of string keys to
    /// <see cref="SilkTouchConfiguration"/> values.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// In each <see cref="SilkTouchConfiguration"/> within <c>"Jobs"</c>, contains a subsection for each of the
    /// <see cref="SilkTouchConfiguration.Mods"/> referenced that has a <see cref="IMod.ConfigurationType"/>.
    /// </description>
    /// </item>
    /// </list>
    /// </param>
    /// <returns>The modified service collection (for chaining purposes).</returns>
    public static IServiceCollection AddSilkTouch(this IServiceCollection services, IConfiguration config)
    {
        services.AddSingleton<ClangScraper>();
        services.AddSingleton<ResponseFileHandler>();

        // Build the config and load the mods
        foreach (var job in config.GetSection("Jobs").GetChildren())
        {
            var mods = job.GetSection("Mods").Get<string[]>() ?? Array.Empty<string>();
            foreach (var m in mods)
            {
                var loadedMod = ModLoader.LoadModByName(m);
                if (loadedMod is not null && services.All(x => x.ImplementationType != loadedMod))
                {
                    services.AddSingleton(loadedMod);
                }
                // TODO else log?

                if (loadedMod?
                        .GetProperty(nameof(IMod.ConfigurationType), BindingFlags.Static)?
                        .GetMethod?
                        .Invoke(null, null) is Type cfgType)
                {
                    _configure
                        .MakeGenericMethod(cfgType)
                        .Invoke(null, new object?[] { services, job.Key, job.GetSection(m) });
                }
            }

            services.Configure<SilkTouchConfiguration>(job.Key, job);
        }

        return services.AddSingleton<SilkTouchGenerator>();
    }
}

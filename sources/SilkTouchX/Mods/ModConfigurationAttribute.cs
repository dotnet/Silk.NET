using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SilkTouchX.Mods;

/// <summary>
/// Annotates the configuration type for this mod - this is used to call
/// <see cref="OptionsConfigurationServiceCollectionExtensions.Configure{TOptions}(IServiceCollection, string, IConfiguration)" />
/// with the appropriate type.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
[RequiresUnreferencedCode("Uses reflection to get attributes on a given mod type.")]
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public class ModConfigurationAttribute<
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TOptions
> : Attribute { }

/// <summary>
/// Contains helper functions for <see cref="ModConfigurationAttribute{TOptions}"/>.
/// </summary>
public static class ModConfigurationAttribute
{
    /// <summary>
    /// Gets the configuration type (if applicable) on the given type as indicated by this attribute.
    /// </summary>
    /// <param name="modType">The mod type to check.</param>
    /// <returns>The type, or null if no configuration is specified.</returns>
    public static Type? GetConfigurationType(Type modType)
    {
        var attribute = modType.GetCustomAttribute(
            typeof(ModConfigurationAttribute<>),
            inherit: false
        );
        if (
            attribute is not null
            && attribute.GetType().GetGenericTypeDefinition() == typeof(ModConfigurationAttribute<>)
        )
        {
            return attribute.GetType().GetGenericArguments()[0];
        }

        return null;
    }
}

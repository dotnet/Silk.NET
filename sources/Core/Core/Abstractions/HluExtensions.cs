// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Contains extension methods (and utility APIs) for HLU types.
/// </summary>
public static class HluExtensions
{
    /// <summary>
    /// Gets an implementation of the given component type if one has already been defined and, if not, queries the
    /// registry to configure the component for the given host.
    /// </summary>
    /// <param name="host">The component host.</param>
    /// <param name="config">The container of configuration with which to initialise components.</param>
    /// <typeparam name="TComponent">The component type.</typeparam>
    /// <typeparam name="THost">The type of the component host.</typeparam>
    /// <typeparam name="TConfiguration">The configuration container type.</typeparam>
    /// <typeparam name="TRegistry">
    /// The registry of component implementations, should the component type not already be configured on the host.
    /// </typeparam>
    /// <returns>The component.</returns>
    /// <exception cref="HluMissingComponentException">
    /// The component was missing in both the host and the registry (or otherwise wasn't added).
    /// </exception>
    public static TComponent GetOrAdd<TComponent, THost, TConfiguration, TRegistry>(
        THost host,
        TConfiguration config
    )
        where THost : IHluComponentHost
        where TConfiguration : IHluConfiguration
        where TRegistry : IHluComponentRegistry
    {
        if (host.TryGet<TComponent>(out var existing))
        {
            return existing;
        }

        if (
            !TRegistry.TryConfigureComponent<TComponent, THost, TConfiguration, TRegistry>(
                host,
                config
            ) || !host.TryGet<TComponent>(out var comp)
        )
        {
            throw new HluMissingComponentException(typeof(TComponent).FullName);
        }

        return comp;
    }

    /// <summary>
    /// Gets a component or throws if it's not present.
    /// </summary>
    /// <param name="host">The component host.</param>
    /// <typeparam name="TComponent">The component type.</typeparam>
    /// <returns>The component.</returns>
    /// <exception cref="HluMissingComponentException">The component was not present on the host.</exception>
    public static TComponent Get<TComponent>(this IHluComponentHost host)
    {
        if (!host.TryGet<TComponent>(out var comp))
        {
            throw new HluMissingComponentException(typeof(TComponent).FullName);
        }

        return comp;
    }
}

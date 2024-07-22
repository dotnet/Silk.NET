// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// A source of component implementations.
/// </summary>
public interface IHluComponentRegistry
{
    /// <summary>
    /// Configures the default components for this registry on a component host. In case this is a nested call, the
    /// original registry used is provided should component dependencies need to be resolved while respecting user
    /// precedence.
    /// </summary>
    /// <param name="dest">The host on which to register components.</param>
    /// <param name="config">The source of configurations with which to initialise components.</param>
    /// <typeparam name="THost">The host type.</typeparam>
    /// <typeparam name="TConfiguration">The type of the configuration source.</typeparam>
    /// <typeparam name="TRegistry">
    /// The original registry. This may differ from the type implementing this interface if this registry is nested
    /// within another registry.
    /// </typeparam>
    static abstract void ConfigureDefaults<THost, TConfiguration, TRegistry>(
        THost dest,
        TConfiguration config
    )
        where THost : IHluComponentHost
        where TConfiguration : IHluConfiguration
        where TRegistry : IHluComponentRegistry;

    /// <summary>
    /// Configures an individual component. This is typically used within
    /// <see cref="ConfigureDefaults{THost,TConfiguration,TRegistry}"/> to configure component dependencies while
    /// respecting user precedence.
    /// </summary>
    /// <param name="dest">The host on which to configure components.</param>
    /// <param name="config">The source of configurations with which to initialise components.</param>
    /// <typeparam name="TComponent">
    /// The component contract type - this is not the implementation type. This is the type used in calls to
    /// <see cref="IHluComponentHost.TryGet{TComponent}"/>.
    /// </typeparam>
    /// <typeparam name="THost">The host type.</typeparam>
    /// <typeparam name="TConfiguration">The type of the configuration source.</typeparam>
    /// <typeparam name="TRegistry">
    /// The original registry. This may differ from the type implementing this interface if this registry is nested
    /// within another registry.
    /// </typeparam>
    /// <returns>Whether the component was configured.</returns>
    static abstract bool TryConfigureComponent<TComponent, THost, TConfiguration, TRegistry>(
        THost dest,
        TConfiguration config
    )
        where THost : IHluComponentHost
        where TConfiguration : IHluConfiguration
        where TRegistry : IHluComponentRegistry;

    /// <summary>
    /// Chains two implementations of <see cref="IHluComponentRegistry"/> together. This is used to facilitate the
    /// builder pattern while preserving typing.
    /// </summary>
    /// <typeparam name="T1">The type of the first configuration to check.</typeparam>
    /// <typeparam name="T2">The type of the second configuration to check.</typeparam>
    public readonly record struct Chain<T1, T2> : IHluComponentRegistry
        where T1 : IHluComponentRegistry
        where T2 : IHluComponentRegistry
    {
        /// <inheritdoc />
        public static void ConfigureDefaults<THost, TConfiguration, TRegistry>(
            THost dest,
            TConfiguration config
        )
            where THost : IHluComponentHost
            where TConfiguration : IHluConfiguration
            where TRegistry : IHluComponentRegistry
        {
            T1.ConfigureDefaults<THost, TConfiguration, TRegistry>(dest, config);
            T2.ConfigureDefaults<THost, TConfiguration, TRegistry>(dest, config);
        }

        /// <inheritdoc />
        public static bool TryConfigureComponent<TComponent, THost, TConfiguration, TRegistry>(
            THost dest,
            TConfiguration config
        )
            where THost : IHluComponentHost
            where TConfiguration : IHluConfiguration
            where TRegistry : IHluComponentRegistry =>
            T1.TryConfigureComponent<TComponent, THost, TConfiguration, TRegistry>(dest, config)
            || T2.TryConfigureComponent<TComponent, THost, TConfiguration, TRegistry>(dest, config);
    }
}

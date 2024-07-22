// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Registers a component on a registry. This will cause the <c>Silk.NET.Core.Analyzers</c> source generators to
/// enumerate all constructors on <typeparamref name="TImpl"/> and try to populate the parameters using
/// <see cref="IHluConfiguration"/> or, if the parameter is annotated with <see cref="HluHostedComponentAttribute"/>,
/// the <see cref="IHluComponentHost"/> or <see cref="IHluComponentRegistry"/> in use. This can be used to declare
/// dependencies on configuration or other components. The constructors are attempted in order of most parameters to
/// least. This logic will be provided within a <see cref="IHluComponentRegistry"/> implementation on the attributed
/// class.
/// </summary>
/// <typeparam name="TComponent">The component type.</typeparam>
/// <typeparam name="TImpl">The component implementation.</typeparam>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor)]
public class HluRegisteredComponentAttribute<TComponent, TImpl>(bool isDefault = true) : Attribute
{
    /// <summary>
    /// Whether the registry will configure the <typeparamref name="TComponent"/> as part of its
    /// <see cref="IHluComponentRegistry.ConfigureDefaults{THost, TConfiguration, TRegistry}"/>.
    /// </summary>
    public bool IsDefault { get; } = isDefault;

    /// <summary>
    /// Whether to override the existing implementation (if any).
    /// </summary>
    public bool Override { get; init; }
}

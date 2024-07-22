// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Core;

/// <summary>
/// A container of multiple components.
/// </summary>
public interface IHluComponentHost
{
    /// <summary>
    /// Throws if the component host is missing required components.
    /// </summary>
    void ThrowIfMisconfigured();

    /// <summary>
    /// Gets an implementation of the given component.
    /// </summary>
    /// <param name="component">
    /// The component implementation, or <c>default</c> if an implementation wasn't present.
    /// </param>
    /// <typeparam name="TComponent">The component contract type - not the implementation type.</typeparam>
    /// <returns>Whether the component was present in this container.</returns>
    bool TryGet<TComponent>([NotNullWhen(true)] out TComponent? component);

    /// <summary>
    /// Adds or overrides a component with the given implementation.
    /// </summary>
    /// <param name="comp">The component implementation.</param>
    /// <typeparam name="TComponent">
    /// The component contract type - not the implementation type. Corresponds with the type parameter for\
    /// <see cref="TryGet{TComponent}"/>.
    /// </typeparam>
    /// <typeparam name="TImpl">The implementation type.</typeparam>
    /// <remarks>
    /// Configuring components that have already been configured on the host should be avoided unless it is explicitly
    /// part of that component's contract.
    /// </remarks>
    /// <returns>Whether the component was added. Currently, this is always true.</returns>
    bool TrySet<TComponent, TImpl>(TImpl comp)
        where TImpl : TComponent;
}

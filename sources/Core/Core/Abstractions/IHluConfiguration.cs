// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Core;

/// <summary>
/// Represents a type that holds initial configurations for components, to be captured upon component instantiation.
/// </summary>
public interface IHluConfiguration
{
    /// <summary>
    /// Attempts to get a configuration of a specific type.
    /// </summary>
    /// <param name="config">The configuration if present. <c>default</c> if not.</param>
    /// <typeparam name="T">The configuration type.</typeparam>
    /// <returns>Whether the configuration was present.</returns>
    bool TryGetConfiguration<T>([NotNullWhen(true)] out T? config);

    /// <summary>
    /// Chains two implementations of <see cref="IHluConfiguration"/> together. This is used to facilitate the builder
    /// pattern while preserving typing.
    /// </summary>
    /// <typeparam name="T1">The type of the first configuration to check.</typeparam>
    /// <typeparam name="T2">The type of the second configuration to check.</typeparam>
    public readonly record struct Chain<T1, T2>(T1 Left, T2 Right) : IHluConfiguration
        where T1 : IHluConfiguration
        where T2 : IHluConfiguration
    {
        /// <inheritdoc />
        public bool TryGetConfiguration<T>([NotNullWhen(true)] out T? config) =>
            Left.TryGetConfiguration(out config) || Right.TryGetConfiguration(out config);
    }
}

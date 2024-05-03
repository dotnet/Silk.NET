// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// Provides typed metadata for API symbols.
/// </summary>
public interface IApiMetadataProvider
{
    /// <summary>
    /// Gets metadata of the given type stored for the function with the given native name.
    /// </summary>
    /// <param name="jobKey">The job key.</param>
    /// <param name="nativeName">The native name.</param>
    /// <param name="metadata">The metadata.</param>
    /// <typeparam name="T">The type of the metadata.</typeparam>
    /// <returns>Whether metadata exists for this symbol. If true, <paramref name="metadata"/> is not null.</returns>
    bool TryGetFunctionMetadata<T>(
        string? jobKey,
        string nativeName,
        [NotNullWhen(true)] out T? metadata
    ) => (metadata = default) is not null;

    /// <summary>
    /// Gets metadata of the given type stored for the parameter with the given name on the function with the given
    /// native name.
    /// </summary>
    /// <param name="jobKey">The job key.</param>
    /// <param name="nativeName">The native name.</param>
    /// <param name="parameterName">The parameter name.</param>
    /// <param name="metadata">The metadata.</param>
    /// <typeparam name="T">The type of the metadata.</typeparam>
    /// <returns>Whether metadata exists for this symbol. If true, <paramref name="metadata"/> is not null.</returns>
    bool TryGetParameterMetadata<T>(
        string? jobKey,
        string nativeName,
        string parameterName,
        [NotNullWhen(true)] out T? metadata
    ) => (metadata = default) is not null;
}

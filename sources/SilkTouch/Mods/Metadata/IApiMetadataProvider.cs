// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// Provides typed metadata for API symbols.
/// </summary>
/// <typeparam name="T">The metadata type.</typeparam>
public interface IApiMetadataProvider<T>
{
    /// <summary>
    /// Gets metadata of the given type stored for the symbol with the given native name.
    /// </summary>
    /// <param name="jobKey">The job key.</param>
    /// <param name="nativeName">The native name.</param>
    /// <param name="metadata">The metadata.</param>
    /// <returns>Whether metadata exists for this symbol. If true, <paramref name="metadata"/> is not null.</returns>
    bool TryGetSymbolMetadata(
        string? jobKey,
        string nativeName,
        [NotNullWhen(true)] out T? metadata
    ) => (metadata = default) is not null;

    /// <summary>
    /// Gets metadata of the given type stored for the child symbol (e.g. parameter) with the given name on the symbol
    /// (e.g. function) with the given native name.
    /// </summary>
    /// <param name="jobKey">The job key.</param>
    /// <param name="nativeName">The native name.</param>
    /// <param name="childNativeName">The parameter name.</param>
    /// <param name="metadata">The metadata.</param>
    /// <returns>Whether metadata exists for this symbol. If true, <paramref name="metadata"/> is not null.</returns>
    bool TryGetChildSymbolMetadata(
        string? jobKey,
        string nativeName,
        string childNativeName,
        [NotNullWhen(true)] out T? metadata
    ) => (metadata = default) is not null;
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Core;

/// <summary>
/// Represents a window that possesses native handles or other platform-specific information.
/// </summary>
public interface INativeWindow
{
    /// <summary>
    /// Attempts to obtain native platform information with type <typeparamref name="TPlatformInfo" />.
    /// </summary>
    /// <param name="info">
    /// The platform-specific information, or <c>default</c> if the platform-specific information is not available for
    /// this platform.
    /// </param>
    /// <returns>True if <paramref name="info" /> contains the platform-specific information, false otherwise.</returns>
    bool TryGetPlatformInfo<TPlatformInfo>([NotNullWhen(true)] out TPlatformInfo? info);
}

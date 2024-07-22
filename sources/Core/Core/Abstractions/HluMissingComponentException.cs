// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Thrown when a HLU component is missing.
/// </summary>
/// <param name="component">The name of the missing component.</param>
public class HluMissingComponentException(string? component)
    : Exception(
        $"The operation could not continue due to a missing component: {component}. This likely indicates an issue "
            + "resolving a native library, but could indicate an incomplete backend."
    )
{
    /// <summary>
    /// Throws a <see cref="HluMissingComponentException"/> for <typeparamref name="T"/> if <paramref name="obj" /> is
    /// <c>null</c>.
    /// </summary>
    /// <param name="obj">The object to check for null.</param>
    /// <typeparam name="T">The component type.</typeparam>
    /// <exception cref="HluMissingComponentException">If <paramref name="obj"/> is <c>null</c>.</exception>
    public static void ThrowIfNull<T>(T? obj)
    {
        if (obj is null)
        {
            throw new HluMissingComponentException(typeof(T).FullName);
        }
    }
}

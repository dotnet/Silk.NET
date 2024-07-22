// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// Represents a boolean marshalling scheme for the given underlying type.
/// </summary>
public interface IBoolScheme
{
    /// <summary>
    /// The <c>true</c> value.
    /// </summary>
    static abstract T True<T>()
        where T : unmanaged, IEquatable<T>, IIncrementOperators<T>, IDecrementOperators<T>;

    /// <summary>
    /// The <c>false</c> value.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static virtual T False<T>()
        where T : unmanaged, IEquatable<T>, IIncrementOperators<T>, IDecrementOperators<T> =>
        default!;

    /// <summary>
    /// Determines whether the given value represents a true value.
    /// </summary>
    /// <param name="value">The underlying value.</param>
    /// <typeparam name="T">The type of the underlying value.</typeparam>
    /// <returns>True or false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    static virtual bool IsTrue<T>(T value)
        where T : unmanaged, IEquatable<T>, IIncrementOperators<T>, IDecrementOperators<T> =>
        !value.Equals(default);
}

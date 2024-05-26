// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// A boolean represented as an underlying value expressed using a specific scheme.
/// </summary>
/// <param name="Value">The underlying value/</param>
/// <typeparam name="T">The underlying type.</typeparam>
/// <typeparam name="TScheme">The scheme used to determine the underlying value.</typeparam>
public readonly record struct MaybeBool<T, TScheme>(T Value)
    where T : unmanaged, IEquatable<T>, IIncrementOperators<T>, IDecrementOperators<T>
    where TScheme : IBoolScheme
{
    /// <summary>
    /// Creates a <see cref="MaybeBool{T,TScheme}"/> from a <typeparamref name="T"/>.
    /// </summary>
    /// <param name="Value">The underlying value.</param>
    /// <returns>The wrapped value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MaybeBool<T, TScheme>(T Value) => new(Value);

    /// <summary>
    /// Gets the underlying value.
    /// </summary>
    /// <param name="value">The wrapped value.</param>
    /// <returns>The underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator T(MaybeBool<T, TScheme> value) => value.Value;

    /// <summary>
    /// Creates a boolean wrapper of the specified type representing the given value.
    /// </summary>
    /// <param name="value">The boolean value.</param>
    /// <returns>The wrapped underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MaybeBool<T, TScheme>(bool value) =>
        value ? TScheme.True<T>() : TScheme.False<T>();

    /// <summary>
    /// Gets the boolean value of this wrapped value.
    /// </summary>
    /// <param name="value">The wrapped underlying value.</param>
    /// <returns>The boolean value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool(MaybeBool<T, TScheme> value) =>
        TScheme.IsTrue(value.Value);
}

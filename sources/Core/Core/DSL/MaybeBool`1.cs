// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// A boolean represented as an underlying value.
/// </summary>
/// <param name="Value">The underlying value/</param>
/// <typeparam name="T">The underlying type.</typeparam>
public readonly record struct MaybeBool<T>(T Value)
    where T : unmanaged, IEquatable<T>, IIncrementOperators<T>
{
    /// <summary>
    /// Creates a <see cref="MaybeBool{T}"/> from a <typeparamref name="T"/>.
    /// </summary>
    /// <param name="Value">The underlying value.</param>
    /// <returns>The wrapped value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MaybeBool<T>(T Value) => new(Value);

    /// <summary>
    /// Gets the underlying value.
    /// </summary>
    /// <param name="value">The wrapped value.</param>
    /// <returns>The underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator T(MaybeBool<T> value) => value.Value;

    /// <summary>
    /// Creates a boolean wrapper of the specified type representing the given value.
    /// </summary>
    /// <param name="value">The boolean value.</param>
    /// <returns>The wrapped underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MaybeBool<T>(bool value)
    {
        var val = default(T);
        if (value)
        {
            val++;
        }

        return val;
    }

    /// <summary>
    /// Gets the boolean value of this wrapped value.
    /// </summary>
    /// <param name="value">The wrapped underlying value.</param>
    /// <returns>The boolean value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool(MaybeBool<T> value) => !value.Value.Equals(default);

    /// <summary>
    /// compares boolean value and int
    /// </summary>
    /// <param name="lh">left hand value</param>
    /// <param name="rh">right hand value</param>
    /// <returns></returns>
    public static bool operator ==(MaybeBool<T> lh, T rh) => lh.Value.Equals(rh);

    /// <summary>
    /// Compares boolean value and int
    /// </summary>
    /// <param name="lh">left hand value</param>
    /// <param name="rh">right hand value</param>
    /// <returns></returns>
    public static bool operator !=(MaybeBool<T> lh, T rh) => !lh.Value.Equals(rh);

    /// <summary>
    /// compares boolean value and int
    /// </summary>
    /// <param name="lh">left hand value</param>
    /// <param name="rh">right hand value</param>
    /// <returns></returns>
    public static bool operator ==(T lh, MaybeBool<T> rh) => lh.Equals(rh.Value);

    /// <summary>
    /// Compares boolean value and int
    /// </summary>
    /// <param name="lh">left hand value</param>
    /// <param name="rh">right hand value</param>
    /// <returns></returns>
    public static bool operator !=(T lh, MaybeBool<T> rh) => !lh.Equals(rh.Value);
}

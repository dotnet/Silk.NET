// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// The "default" option for variance of DSL types using type parameters. For example, use this in place of a
/// <see cref="IBoolScheme"/> type parameter to use the default boolean scheme (as implemented by
/// <see cref="MaybeBool{T}"/>)
/// </summary>
public class Default : IBoolScheme
{
    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static T True<T>()
        where T : unmanaged, IEquatable<T>, IIncrementOperators<T>, IDecrementOperators<T>
    {
        var ret = default(T);
        ret++;
        return ret;
    }
}

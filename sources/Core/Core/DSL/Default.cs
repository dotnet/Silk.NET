// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// The "default" option for variance of DSL types using type parameters.
/// <list type="bullet">
/// <item>
/// <description>
/// Use this in place of a <see cref="IBoolScheme"/> type parameter to use the default boolean scheme (as implemented by
/// <see cref="MaybeBool{T}"/>)
/// </description>
/// </item>
/// <item>
/// </item>
/// </list>
/// </summary>
public struct Default : IBoolScheme
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

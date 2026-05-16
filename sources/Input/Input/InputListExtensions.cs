// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// Some utility methods for more easily handling the input-specific list types
/// </summary>
public static class InputListExtensions
{
    /// <summary>
    /// A utility method for converting to an <see cref="IReadOnlyList{T}"/> without boxing (triggering unnecessary
    /// garbage creation via struct => object conversion) by simply passing along the underlying list
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IReadOnlyList<Button<T>> AsReadOnlyList<T>(this ButtonReadOnlyList<T> list) where T : unmanaged, Enum => list.List;
}

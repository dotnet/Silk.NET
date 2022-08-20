// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Helpers to work with <see cref="ImmutableArray{T}"/>
/// </summary>
public static class ImmutableArrayHelpers
{
    /// <summary>
    /// Replaces any elements matching a predicate and adds a new element in one efficient operation.
    /// Commonly used to replace <see cref="ISymbolAnnotation"/>s on derived symbols
    /// </summary>
    /// <param name="source">The original array</param>
    /// <param name="old">The predicate used to find elements that need removal</param>
    /// <param name="new">The new element to add</param>
    /// <typeparam name="T">The type of elements in the arrays</typeparam>
    /// <returns>The new array</returns>
    public static ImmutableArray<T> ReplaceOrAdd<T>(this ImmutableArray<T> source, Predicate<T> old, T @new)
    {
        var builder = source.ToBuilder();

        while (true)
        {
            for (var index = 0; index < builder.Count; index++)
            {
                if (old(builder[index]))
                {
                    builder.RemoveAt(index);
                    index--;
                }
            }
            builder.Add(@new);
            // PERF: This incurs a re-allocation :/
            if (builder.Capacity != builder.Count)
            {
                builder.Capacity = builder.Count;
            }
            return builder.MoveToImmutable();
        }
    }
}

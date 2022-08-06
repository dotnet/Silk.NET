// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A simple type store to store and reference <see cref="TypeSymbol"/>s by Id
/// </summary>
public sealed class TypeStore
{
    private ConcurrentDictionary<TypeId, TypeSymbol> _dictionary = new();

    /// <summary>
    /// Stores the given <see cref="TypeSymbol"/> for later resolution
    /// </summary>
    /// <param name="typeSymbol">The <see cref="TypeSymbol"/> to store</param>
    public void Store(TypeSymbol typeSymbol)
    {
        _dictionary[typeSymbol.Id] = typeSymbol;
    }

    /// <summary>
    /// Resolves a <see cref="TypeSymbol"/> by it's <see cref="TypeSymbol.Id"/>
    /// </summary>
    /// <param name="id">The Id to use for resolution</param>
    /// <param name="typeSymbol">The <see cref="TypeSymbol"/> found or null</param>
    /// <returns>Whether a type could be resolved</returns>
    public bool TryResolve(TypeId id, out TypeSymbol? typeSymbol)
    {
        return _dictionary.TryGetValue(id, out typeSymbol);
    }
}

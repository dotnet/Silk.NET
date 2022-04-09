// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Implements a base visitor to extend when rewriting or otherwise searching through a <see cref="Symbol"/>
/// </summary>
public abstract class SymbolVisitor
{
    /// <summary>
    /// Visit a Symbol. This will call the appropriate method based on the actual type of the <paramref name="symbol"/>
    /// </summary>
    /// <param name="symbol">The symbol to visit</param>
    /// <returns>The rewritten symbol. May be equal to the original symbol of no rewriting has taken place.</returns>
    public virtual Symbol Visit(Symbol symbol)
    {
        return symbol;
    }
}

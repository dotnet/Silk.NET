// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Represents an unresolved <see cref="TypeReference"/>. The Text is arbitrary data that should be interpreted into another <see cref="TypeReference"/>.
/// Visitors are free to throw <see cref="InvalidOperationException"/> using <see cref="ThrowInvalidSymbol"/> when they encounter this symbol, but type resolution should've already happened.
/// </summary>
/// <param name="Text">Arbitrary text to interpret</param>
/// <param name="Annotations">The annotations of this symbol</param>
public sealed record UnresolvedTypeReference
    (string Text, ImmutableArray<ISymbolAnnotation> Annotations) : TypeReference(Annotations)
{
    /// <summary>
    /// Throw helper to use when encountering <see cref="UnresolvedTypeReference"/> when type resolution should've already happened.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public static void ThrowInvalidSymbol(UnresolvedTypeReference utr)
    {
        // This is by far the most common exception during generation, so make sure it's useful!!
        throw new InvalidOperationException
        (
            $"Visited {nameof(UnresolvedTypeReference)}, but type resolution should have already happened. Text: \"{utr.Text}\""
        );
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution.Annotations;

namespace Silk.NET.SilkTouch.TypeResolution;

/// <summary>
/// A base to simplify creation of basic type resolvers that only need simple text matching.
/// </summary>
public abstract class SimpleTypeResolverBase : SymbolVisitor
{
    /// <inheritdoc />
    protected SimpleTypeResolverBase(TypeStore typeStore) : base(typeStore)
    {
    }

    /// <inheritdoc />
    protected override TypeReference VisitTypeReference(TypeReference typeSymbol)
    {
        while (true)
        {
            if (typeSymbol is UnresolvedTypeReference utr)
            {
                if (TryResolve(utr, out var result))
                {
                    Debug.Assert(result is not null);
                    if (result!.Annotations == typeSymbol.Annotations)
                    {
                        result = result with
                        {
                            Annotations = result.Annotations.ReplaceOrAdd
                                (x => x is ResolvedFromAnnotation, new ResolvedFromAnnotation(utr.Text))
                        };
                    }
                    typeSymbol = result;
                    continue;
                }
                return utr;
            }
            return base.VisitTypeReference(typeSymbol);
        }
    }

    /// <summary>
    /// Resolve an <see cref="UnresolvedTypeReference"/>
    /// </summary>
    /// <param name="utr">THe unresolved reference to attempt to resolve</param>
    /// <param name="resolved">The resolved reference. May not be null if true is returned.</param>
    /// <returns>Whether resolution was successful</returns>
    /// <remarks>
    /// This method is free to return a partial resolution, and still return true.
    /// Partial resolutions are such that do not have a <see cref="UnresolvedTypeReference"/> at the root,
    /// but have <see cref="UnresolvedTypeReference"/> somewhere in the tree.
    /// </remarks>
    /// <remarks>
    /// Implementors don't need to worry about adding <see cref="ResolvedFromAnnotation"/>. This is done automatically.
    /// </remarks>
    protected abstract bool TryResolve(UnresolvedTypeReference utr, out TypeReference? resolved);
}

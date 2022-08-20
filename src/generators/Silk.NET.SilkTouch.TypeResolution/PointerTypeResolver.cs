// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.TypeResolution;

/// <summary>
/// Resolves <see cref="UnresolvedTypeReference"/>s with Text like "a*", "a.b.c*" to a <see cref="PointerTypeReference"/> with the underlying set to an <see cref="UnresolvedTypeReference"/> with text = "a", "a.b.c", etc.
/// </summary>
/// <example>
/// <list type="table">
/// <listheader>
/// <term>Input Tree</term>
/// <description>Output Tree</description>
/// </listheader>
///
/// <item>
/// <term><see cref="UnresolvedTypeReference"/>(Text = "a.b.c*")</term>
/// <description><see cref="PointerTypeReference"/>(Underlying = <see cref="UnresolvedTypeReference"/>(Text = "a.b.c"))</description>
/// </item>
/// 
/// <item>
/// <term><see cref="UnresolvedTypeReference"/>(Text = "int*")</term>
/// <description><see cref="PointerTypeReference"/>(Underlying = <see cref="UnresolvedTypeReference"/>(Text = "int"))</description>
/// </item>
/// 
/// <item>
/// <term><see cref="UnresolvedTypeReference"/>(Text = "a")</term>
/// <description><see cref="UnresolvedTypeReference"/>(Text = "a")</description>
/// </item>
/// </list>
/// </example>
public sealed class PointerTypeResolver : SimpleTypeResolverBase
{

    /// <inheritdoc />
    public PointerTypeResolver(TypeStore typeStore) : base(typeStore)
    {
    }

    /// <inheritdoc />
    protected override bool TryResolve(UnresolvedTypeReference utr, out TypeReference? resolved)
    {
        if (utr.Text.Length > 1 && utr.Text[utr.Text.Length - 1] == '*')
        {
            resolved = new PointerTypeReference
            (
                new UnresolvedTypeReference
                    (utr.Text.Substring(0, utr.Text.Length - 1), ImmutableArray<ISymbolAnnotation>.Empty),
                utr.Annotations
            );
            return true;
        }
        resolved = null;
        return false;
    }
}

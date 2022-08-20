// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.TypeResolution;

/// <summary>
/// A simple type resolver to resolve <see cref="UnresolvedTypeReference"/>s that refer to primitive types.
/// </summary>
public sealed class PrimitiveTypeResolver : SimpleTypeResolverBase
{

    /// <inheritdoc />
    public PrimitiveTypeResolver(TypeStore typeStore) : base(typeStore)
    {
    }

    private static ExternalTypeReference CreateExternalTypeRef(string? @namespace, string name)
        => new ExternalTypeReference
        (
            @namespace is not null ? new IdentifierSymbol(@namespace, ImmutableArray<ISymbolAnnotation>.Empty) : null,
            new IdentifierSymbol(name, ImmutableArray<ISymbolAnnotation>.Empty),
            ImmutableArray<ISymbolAnnotation>.Empty
        );
    private static readonly Dictionary<string, TypeReference> _typeMap = new Dictionary<string, TypeReference>()
    {
        ["bool"] = CreateExternalTypeRef("System", "Boolean"),
        ["byte"] = CreateExternalTypeRef("System", "Byte"),
        ["sbyte"] = CreateExternalTypeRef("System", "SByte"),
        ["char"] = CreateExternalTypeRef("System", "Char"),
        ["decimal"] = CreateExternalTypeRef("System", "Decimal"),
        ["double"] = CreateExternalTypeRef("System", "Double"),
        ["float"] = CreateExternalTypeRef("System", "Single"),
        ["int"] = CreateExternalTypeRef("System", "Int32"),
        ["uint"] = CreateExternalTypeRef("System", "UInt32"),
        ["nint"] = CreateExternalTypeRef("System", "IntPtr"),
        ["nuint"] = CreateExternalTypeRef("System", "UIntPtr"),
        ["long"] = CreateExternalTypeRef("System", "Int64"),
        ["ulong"] = CreateExternalTypeRef("System", "UInt64"),
        ["short"] = CreateExternalTypeRef("System", "Int16"),
        ["ushort"] = CreateExternalTypeRef("System", "UInt16"),
        ["void"] = CreateExternalTypeRef(null, "void")
    };

    /// <inheritdoc />
    protected override bool TryResolve(UnresolvedTypeReference utr, out TypeReference? resolved)
    {
        return _typeMap.TryGetValue(utr.Text, out resolved);
    }
}

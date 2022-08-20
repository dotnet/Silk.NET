// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution.Annotations;
using Xunit;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public sealed class PrimitiveTypeResolverTests
{
    [Theory, Trait("Category", "Type Resolution"),
        InlineData("bool", "System", "Boolean"),
        InlineData("byte", "System", "Byte"),
        InlineData("sbyte", "System", "SByte"),
        InlineData("char", "System", "Char"),
        InlineData("decimal", "System", "Decimal"),
        InlineData("double", "System", "Double"),
        InlineData("float", "System", "Single"),
        InlineData("int", "System", "Int32"),
        InlineData("uint", "System", "UInt32"),
        InlineData("nint", "System", "IntPtr"),
        InlineData("nuint", "System", "UIntPtr"),
        InlineData("long", "System", "Int64"),
        InlineData("ulong", "System", "UInt64"),
        InlineData("short", "System", "Int16"),
        InlineData("ushort", "System", "UInt16"),
        InlineData("void", null, "void"),
    ]
    public void ShouldResolve(string text, string? @namespace, string identifier)
    {
        var symbol = new UnresolvedTypeReference(text, ImmutableArray<ISymbolAnnotation>.Empty);
        var output = new PrimitiveTypeResolver(new TypeStore());

        var finalSymbol = output.Visit(symbol);
        var @ref = Assert.IsType<ExternalTypeReference>(finalSymbol);
        Assert.Equal(@namespace, @ref.Namespace?.Value);
        Assert.Equal(identifier, @ref.TypeIdentifier.Value);
        Assert.Equal(text, Assert.IsType<ResolvedFromAnnotation>(Assert.Single(@ref.Annotations)).OriginalString);
    }

    [Theory, Trait("Category", "Type Resolution"),
        InlineData(""),
        InlineData("a"),
        InlineData("*"),
        InlineData("a.b.c"),
        InlineData("longType"),
        InlineData("using")
    ]
    public void ShouldNotResolve(string text)
    {
        var symbol = new UnresolvedTypeReference(text, ImmutableArray<ISymbolAnnotation>.Empty);
        var output = new PrimitiveTypeResolver(new TypeStore());

        var finalSymbol = output.Visit(symbol);
        Assert.IsNotType<ExternalTypeReference>(finalSymbol);
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution.Annotations;
using Xunit;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public sealed class PointerResolverTests
{
    [Theory, Trait("Category", "Type Resolution"), 
        InlineData("a*"),
        InlineData("a.b.c*"),
        InlineData("int*")
    ]
    public void ShouldResolve(string text)
    {
        var symbol = new UnresolvedTypeReference(text, ImmutableArray<ISymbolAnnotation>.Empty);
        var output = new PointerTypeResolver(new TypeStore());

        var finalSymbol = output.Visit(symbol);
        var typed = Assert.IsType<PointerTypeReference>(finalSymbol);
        Assert.Equal(text, Assert.IsType<ResolvedFromAnnotation>(Assert.Single(typed.Annotations)).OriginalString);
    }

    [Theory, Trait("Category", "Type Resolution"),
        InlineData(""),
        InlineData("a"),
        InlineData("*"),
        InlineData("a.b.c"),
        InlineData("longType"),
        InlineData("int"),
        InlineData("using")
    ]
    public void ShouldNotResolve(string text)
    {
        var symbol = new UnresolvedTypeReference(text, ImmutableArray<ISymbolAnnotation>.Empty);
        var output = new PointerTypeResolver(new TypeStore());

        var finalSymbol = output.Visit(symbol);
        Assert.IsNotType<PointerTypeReference>(finalSymbol);
    }

    [Fact, Trait("Category", "Type Resolution")]
    public void MultiPointer()
    {
        var symbol = new UnresolvedTypeReference("int***", ImmutableArray<ISymbolAnnotation>.Empty);
        var output = new PointerTypeResolver(new TypeStore());

        var finalSymbol = output.Visit(symbol);
        var outer = Assert.IsType<PointerTypeReference>(finalSymbol);
        var middle = Assert.IsType<PointerTypeReference>(outer.Underlying);
        var inner = Assert.IsType<PointerTypeReference>(middle.Underlying);
        Assert.IsNotType<PointerTypeReference>(inner.Underlying);
        
        Assert.Equal("int***", Assert.IsType<ResolvedFromAnnotation>(Assert.Single(outer.Annotations)).OriginalString);
        Assert.Equal("int**", Assert.IsType<ResolvedFromAnnotation>(Assert.Single(middle.Annotations)).OriginalString);
        Assert.Equal("int*", Assert.IsType<ResolvedFromAnnotation>(Assert.Single(inner.Annotations)).OriginalString);
    }
}

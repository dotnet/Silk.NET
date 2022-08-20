// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using System.ComponentModel;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class IdentifierSymbolTests : EmitterTest
{
    [Theory, Trait("Category", "Symbols"),
     Trait("Target Language", "C#")]
    [InlineData("a", "a")]
    [InlineData("int", "int")]
    [InlineData("using", "using")]
    [InlineData("veryLongIdentifierName", "veryLongIdentifierName")]
    [InlineData("this is invalid # /**/", "this is invalid # /**/")]
    public void StringTest(string identifierText, string csharp)
    {
        var symbol = new IdentifierSymbol(identifierText, ImmutableArray<ISymbolAnnotation>.Empty);

        var transformed = Transform(symbol);
        
        Assert.Equal(csharp, transformed.ToFullString());
    }
    
    [Fact,
     Trait("Category", "Emitter"),
     Trait("Target Language", "C#")]
    public void IdentifierHasNoLeadingTrivia()
    {
        var node = Transform(new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty));
        
        Assert.Empty(node.GetLeadingTrivia());
        Assert.False(node.HasLeadingTrivia);
    }
    
    [Fact,
     Trait("Category", "Emitter"),
     Trait("Target Language", "C#")]
    public void IdentifierHasNoTrailingTrivia()
    {
        var node = Transform(new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty));
        
        Assert.Empty(node.GetTrailingTrivia());
        Assert.False(node.HasTrailingTrivia);
    }
}

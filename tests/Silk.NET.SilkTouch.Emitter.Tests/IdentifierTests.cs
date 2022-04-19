// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public sealed class IdentifierTests : EmitterTest
{
    [Fact]
    public void IdentifierHasNoLeadingTrivia()
    {
        var node = Transform(new IdentifierSymbol("Test"));
        
        Assert.Empty(node.GetLeadingTrivia());
        Assert.False(node.HasLeadingTrivia);
    }
    
    [Fact]
    public void IdentifierHasNoTrailingTrivia()
    {
        var node = Transform(new IdentifierSymbol("Test"));
        
        Assert.Empty(node.GetTrailingTrivia());
        Assert.False(node.HasTrailingTrivia);
    }

    [Fact]
    public void IdentifierIntegration()
    {
        var node = Transform(new IdentifierSymbol("Test"));
        
        Assert.Equal("Test", node.ToFullString());
    }
}

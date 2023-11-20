// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class ExternalTypeReferenceTests : EmitterTest
{
    [Fact, Trait("Category", "Symbols"),
     Trait("Target Language", "C#")]
    public void StringTestNoNamespace()
    {
        var symbol = new ExternalTypeReference
        (
            null,
            new IdentifierSymbol("ETR1", ImmutableArray<ISymbolAnnotation>.Empty),
            ImmutableArray<ISymbolAnnotation>.Empty
        );

        var transformed = Transform(symbol);

        Assert.Equal("ETR1", transformed.ToFullString());
    }
    
    [Fact, Trait("Category", "Symbols"),
     Trait("Target Language", "C#")]
    public void StringTestWithNamespace()
    {
        var symbol = new ExternalTypeReference
        (
            new IdentifierSymbol("Namespace", ImmutableArray<ISymbolAnnotation>.Empty),
            new IdentifierSymbol("ETR1", ImmutableArray<ISymbolAnnotation>.Empty),
            ImmutableArray<ISymbolAnnotation>.Empty
        );

        var transformed = Transform(symbol);

        Assert.Equal("Namespace.ETR1", transformed.ToFullString());
    }
}

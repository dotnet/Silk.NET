// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class StaticExternalMethodSymbolTests : EmitterTest
{
    [Fact, Trait("Category", "Symbols")]
    public void StringTestNoParameters()
    {
        var symbol = new StaticExternalMethodSymbol
        (
            new ExternalTypeReference
            (
                null,
                new IdentifierSymbol("int", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            ),
            ImmutableArray<Parameter>.Empty,
            new IdentifierSymbol("M", ImmutableArray<ISymbolAnnotation>.Empty),
            ImmutableArray<ISymbolAnnotation>.Empty
        );

        var transformed = Transform(symbol);

        Assert.Equal("public static extern int M();", transformed.ToFullString());
    }
}

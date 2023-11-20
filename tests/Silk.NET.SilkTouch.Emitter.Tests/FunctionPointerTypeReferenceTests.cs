// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class FunctionPointerTypeReferenceTests : EmitterTest
{
    [Fact, Trait("Category", "Symbols"),
     Trait("Target Language", "C#")]
    public void StringTestNoParams()
    {
        var symbol = new FunctionPointerTypeReference
        (
            new ExternalTypeReference
            (
                null,
                new IdentifierSymbol("Ret", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            ),
            ImmutableArray<TypeReference>.Empty,
            ImmutableArray<ISymbolAnnotation>.Empty
        );

        var transformed = Transform(symbol);

        Assert.Equal("delegate* unmanaged<Ret>", transformed.ToFullString());
    }
    
    [Fact, Trait("Category", "Symbols"),
     Trait("Target Language", "C#")]
    public void StringTestWithParams()
    {
        var symbol = new FunctionPointerTypeReference
        (
            new ExternalTypeReference
            (
                null,
                new IdentifierSymbol("Ret", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            ),
            ImmutableArray.Create<TypeReference>
            (
                new ExternalTypeReference
                (
                    null,
                    new IdentifierSymbol("Param1", ImmutableArray<ISymbolAnnotation>.Empty),
                    ImmutableArray<ISymbolAnnotation>.Empty
                ),
                new ExternalTypeReference
                (
                    null,
                    new IdentifierSymbol("Param2", ImmutableArray<ISymbolAnnotation>.Empty),
                    ImmutableArray<ISymbolAnnotation>.Empty
                )
            ),
            ImmutableArray<ISymbolAnnotation>.Empty
        );

        var transformed = Transform(symbol);

        Assert.Equal("delegate* unmanaged<Param1, Param2, Ret>", transformed.ToFullString());
    }
}

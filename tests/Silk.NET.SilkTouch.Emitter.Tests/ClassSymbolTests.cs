// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public sealed class ClassSymbolTests : EmitterTest
{
    [Fact, Trait("Category", "Symbols"), Trait("Target Language", "C#")]
    public void StringTestNoMethods()
    {
        var symbol = new ClassSymbol
        (
            TypeId.CreateNew(),
            new IdentifierSymbol("C", ImmutableArray<ISymbolAnnotation>.Empty),
            ImmutableArray<MemberSymbol>.Empty,
            ImmutableArray<ISymbolAnnotation>.Empty
        );

        var result = Transform(symbol);

        Assert.Equal("public class C\n" + "{\n" + "}", result.ToFullString());
    }

    [Fact, Trait("Category", "Symbols"), Trait("Target Language", "C#")]
    public void StringTestWithMethods()
    {
        var method = new StaticExternalMethodSymbol
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
        var symbol = new ClassSymbol
        (
            TypeId.CreateNew(),
            new IdentifierSymbol("C", ImmutableArray<ISymbolAnnotation>.Empty),
            ImmutableArray.Create<MemberSymbol>(method),
            ImmutableArray<ISymbolAnnotation>.Empty
        );



        var result = Transform(symbol);

        Assert.Equal("public class C\n" + "{" + "\n    public static extern int M();" + "\n}", result.ToFullString());
    }
}

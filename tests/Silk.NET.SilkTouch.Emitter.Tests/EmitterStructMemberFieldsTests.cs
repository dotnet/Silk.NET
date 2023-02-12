// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class EmitterStructMemberFieldsTests : EmitterTest
{

    [Fact,
     Trait("Category", "Emitter"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields"),
     Trait("Target Language", "C#")]
    public void SingleFieldIntegration()
    {
        var node = Transform
        (
            new StructSymbol
            (
                TypeId.CreateNew(),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray.Create
                (
                    (MemberSymbol)new FieldSymbol
                    (
                        new ExternalTypeReference
                        (
                            null,
                            new IdentifierSymbol("int", ImmutableArray<ISymbolAnnotation>.Empty),
                            ImmutableArray<ISymbolAnnotation>.Empty
                        ),
                        new IdentifierSymbol("F1", ImmutableArray<ISymbolAnnotation>.Empty),
                        ImmutableArray<ISymbolAnnotation>.Empty
                    )
                ),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        );

        Assert.Equal
        (
            @"public struct Test
{
    public int F1;
}", node.ToFullString()
        );
    }
    
    [Fact,
     Trait("Category", "Emitter"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields"),
     Trait("Target Language", "C#")]
    public void MultipleFieldsIntegration()
    {
        var node = Transform
        (
            new StructSymbol
            (
                TypeId.CreateNew(),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray.Create
                (
                    (MemberSymbol)new FieldSymbol
                    (
                        new ExternalTypeReference
                        (
                            null,
                            new IdentifierSymbol("int", ImmutableArray<ISymbolAnnotation>.Empty),
                            ImmutableArray<ISymbolAnnotation>.Empty
                        ),
                        new IdentifierSymbol("F1", ImmutableArray<ISymbolAnnotation>.Empty),
                        ImmutableArray<ISymbolAnnotation>.Empty
                    ),
                    new FieldSymbol
                    (
                        new ExternalTypeReference
                        (
                            null,
                            new IdentifierSymbol("int", ImmutableArray<ISymbolAnnotation>.Empty),
                            ImmutableArray<ISymbolAnnotation>.Empty
                        ),
                        new IdentifierSymbol("F2", ImmutableArray<ISymbolAnnotation>.Empty),
                        ImmutableArray<ISymbolAnnotation>.Empty
                    ),
                    new FieldSymbol
                    (
                        new ExternalTypeReference
                        (
                            null,
                            new IdentifierSymbol("int", ImmutableArray<ISymbolAnnotation>.Empty),
                            ImmutableArray<ISymbolAnnotation>.Empty
                        ),
                        new IdentifierSymbol("F3", ImmutableArray<ISymbolAnnotation>.Empty),
                        ImmutableArray<ISymbolAnnotation>.Empty
                    )
                ),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        );

        Assert.Equal
        (
            @"public struct Test
{
    public int F1;
    public int F2;
    public int F3;
}", node.ToFullString()
        );
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public sealed class EmitterStructTests : EmitterTest
{

    [Fact,
     Trait("Category", "Emitter"),
     Trait("Feature", "Structs"),
     Trait("Target Language", "C#")]
    public void StructSyntax()
    {
        var syntax = Transform(new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty), ImmutableArray<MemberSymbol>.Empty, ImmutableArray<ISymbolAnnotation>.Empty));
        Assert.IsType<StructDeclarationSyntax>(syntax);
    }

    [Fact,
     Trait("Category", "Emitter"),
     Trait("Feature", "Structs"),
     Trait("Target Language", "C#")]
    public void StructKeyword()
    {
        var syntax = Transform
        (
            new StructSymbol
            (
                TypeId.CreateNew(),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<MemberSymbol>.Empty,
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        ) as StructDeclarationSyntax;
        Assert.Equal("struct", syntax!.Keyword.Text);
    }

    [Fact,
     Trait("Category", "Emitter"),
     Trait("Feature", "Structs"),
     Trait("Target Language", "C#")]
    public void CorrectIdentifier()
    {
        var syntax = Transform
        (
            new StructSymbol
            (
                TypeId.CreateNew(),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<MemberSymbol>.Empty,
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        ) as StructDeclarationSyntax;
        Assert.Equal("Test", syntax!.Identifier.Text);
    }

    [Fact,
     Trait("Category", "Emitter"),
     Trait("Feature", "Structs"),
     Trait("Target Language", "C#")]
    public void IsOnlyPublic()
    {
        var syntax = Transform
        (
            new StructSymbol
            (
                TypeId.CreateNew(),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<MemberSymbol>.Empty,
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        ) as StructDeclarationSyntax;
        var @public = Assert.Single(syntax!.Modifiers);
        Assert.Equal("public", @public.Text);
    }

    [Fact,
     Trait("Category", "Emitter"),
     Trait("Feature", "Structs"),
     Trait("Target Language", "C#")]
    public void IntegrationEmptyStruct()
    {
        // Note that this test also covers trivia, which is not checked otherwise.
        Assert.Equal
        (
            @"public struct Test
{
}",
            Transform
                (
                    new StructSymbol
                    (
                        TypeId.CreateNew(),
                        new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                        ImmutableArray<MemberSymbol>.Empty,
                        ImmutableArray<ISymbolAnnotation>.Empty
                    )
                )
                .ToFullString()
        );
    }
}

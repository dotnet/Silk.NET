// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public sealed class EmitterFieldIntegrationTests : EmitterTest
{
    [Fact, 
     Trait("Category", "Emitter"),
     Trait("Feature", "Fields"),
    Trait("Target Language", "C#")]
    public void FieldIntegration()
    {
        var syntax = Transform
        (
            new FieldSymbol
            (
                new ExternalTypeReference
                (
                    null,
                    new IdentifierSymbol("int", ImmutableArray<ISymbolAnnotation>.Empty),
                    ImmutableArray<ISymbolAnnotation>.Empty
                ),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        );

        var result = syntax.ToFullString();
        Assert.Equal("public int Test;", result);
    }

    [Fact, 
     Trait("Category", "Emitter"),
     Trait("Feature", "Fields"),
     Trait("Target Language", "C#")]
    public void FieldIsPublic()
    {
        var syntax = Transform
        (
            new FieldSymbol
            (
                new ExternalTypeReference
                (
                    null,
                    new IdentifierSymbol("", ImmutableArray<ISymbolAnnotation>.Empty),
                    ImmutableArray<ISymbolAnnotation>.Empty
                ),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        ) as FieldDeclarationSyntax;

        Assert.NotNull(syntax);
        Assert.Single(syntax!.Modifiers, x => x.IsKind(SyntaxKind.PublicKeyword));
    }

    [Fact, 
     Trait("Category", "Emitter"),
     Trait("Feature", "Fields"),
     Trait("Target Language", "C#")]
    public void CorrectTypeIdentifier()
    {
        var syntax = Transform
        (
            new FieldSymbol
            (
                new ExternalTypeReference
                (
                    null,
                    new IdentifierSymbol("int", ImmutableArray<ISymbolAnnotation>.Empty),
                    ImmutableArray<ISymbolAnnotation>.Empty
                ),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        ) as FieldDeclarationSyntax;

        Assert.NotNull(syntax);
        var type = syntax!.Declaration.Type as SimpleNameSyntax;
        Assert.NotNull(type);
        Assert.Equal("int", type!.Identifier.Text);
    }

    [Fact, 
     Trait("Category", "Emitter"),
     Trait("Feature", "Fields"),
     Trait("Target Language", "C#")]
    public void CorrectIdentifier()
    {
        var syntax = Transform
        (
            new FieldSymbol
            (
                new ExternalTypeReference
                (
                    null,
                    new IdentifierSymbol("", ImmutableArray<ISymbolAnnotation>.Empty),
                    ImmutableArray<ISymbolAnnotation>.Empty
                ),
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        ) as FieldDeclarationSyntax;

        Assert.NotNull(syntax);

        var variableDeclaratorSyntax = Assert.Single(syntax!.Declaration.Variables);
        Assert.Equal("Test", variableDeclaratorSyntax.Identifier.Text);
    }
}

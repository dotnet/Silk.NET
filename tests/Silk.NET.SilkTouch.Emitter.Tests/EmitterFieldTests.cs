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
    [Fact]
    public void FieldIntegration()
    {
        var syntax = Transform(new FieldSymbol(new StructSymbol(new IdentifierSymbol("int"),ImmutableArray<FieldSymbol>.Empty), new IdentifierSymbol("Test")));

        var result = syntax.ToFullString();
        Assert.Equal("public int Test;", result);
    }

    [Fact]
    public void FieldIsPublic()
    {
        var syntax = Transform
        (
            new FieldSymbol
            (
                new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<FieldSymbol>.Empty),
                new IdentifierSymbol("Test")
            )
        ) as FieldDeclarationSyntax;

        Assert.NotNull(syntax);
        Assert.Single(syntax!.Modifiers, x => x.IsKind(SyntaxKind.PublicKeyword));
    }

    [Fact]
    public void CorrectTypeIdentifier()
    {
        var syntax = Transform
        (
            new FieldSymbol
            (
                new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<FieldSymbol>.Empty),
                new IdentifierSymbol("Test")
            )
        ) as FieldDeclarationSyntax;

        Assert.NotNull(syntax);
        var type = syntax!.Declaration.Type as SimpleNameSyntax;
        Assert.NotNull(type);
        Assert.Equal("int", type!.Identifier.Text);
    }

    [Fact]
    public void CorrectIdentifier()
    {
        var syntax = Transform
        (
            new FieldSymbol
            (
                new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<FieldSymbol>.Empty),
                new IdentifierSymbol("Test")
            )
        ) as FieldDeclarationSyntax;

        Assert.NotNull(syntax);

        var variableDeclaratorSyntax = Assert.Single(syntax!.Declaration.Variables);
        Assert.Equal("Test", variableDeclaratorSyntax.Identifier.Text);
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class EmitterNamespaceTests : EmitterTest
{
    [Fact]
    public void NamespaceIntegration()
    {
        var syntax = Transform(new NamespaceSymbol(new IdentifierSymbol("Test"), ImmutableArray<TypeSymbol>.Empty));

        var result = syntax.ToFullString();
        Assert.Equal("namespace Test\n{\n}", result);
    }

    [Fact]
    public void NamespaceHasCorrectIdentifier()
    {
        var syntax = Transform
                (new NamespaceSymbol(new IdentifierSymbol("Test"), ImmutableArray<TypeSymbol>.Empty)) as
            NamespaceDeclarationSyntax;

        Assert.NotNull(syntax);

        Assert.Equal("Test", Assert.IsType<IdentifierNameSyntax>(syntax!.Name).Identifier.Text);
    }
}

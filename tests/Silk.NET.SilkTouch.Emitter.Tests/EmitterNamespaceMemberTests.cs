// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class EmitterNamespaceMemberTests : EmitterTest
{
    [Fact, 
     Trait("Category", "Emitter"),
     Trait("Feature", "Namespaces"),
     Trait("Target Language", "C#")]
    public void SingleMemberIntegration()
    {
        var syntax = Transform(new NamespaceSymbol(new IdentifierSymbol("Test"), new []
        {
            (TypeSymbol)new StructSymbol(new IdentifierSymbol("Test2"), ImmutableArray<FieldSymbol>.Empty)
        }.ToImmutableArray()));

        var result = syntax.ToFullString();
        Assert.Equal("namespace Test\n{\npublic struct Test2\n{\n}\n}\n", result);
    }
    
    [Fact, 
     Trait("Category", "Emitter"),
     Trait("Feature", "Namespaces"),
     Trait("Target Language", "C#")]
    public void MultipleMembersIntegration()
    {
        var syntax = Transform(new NamespaceSymbol(new IdentifierSymbol("Test"), new []
        {
            (TypeSymbol)new StructSymbol(new IdentifierSymbol("Test2"), ImmutableArray<FieldSymbol>.Empty),
            (TypeSymbol)new StructSymbol(new IdentifierSymbol("Test3"), ImmutableArray<FieldSymbol>.Empty)
        }.ToImmutableArray()));

        var result = syntax.ToFullString();
        Assert.Equal("namespace Test\n{\npublic struct Test2\n{\n}\npublic struct Test3\n{\n}\n}\n", result);
    }
}

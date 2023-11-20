// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
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
        var syntax = Transform
        (
            new NamespaceSymbol
            (
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray.Create<TypeSymbol>
                (
                    new StructSymbol
                    (
                        TypeId.CreateNew(),
                        new IdentifierSymbol("Test2", ImmutableArray<ISymbolAnnotation>.Empty),
                        ImmutableArray<MemberSymbol>.Empty,
                        ImmutableArray<ISymbolAnnotation>.Empty
                    )
                ),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        );

        var result = syntax.ToFullString();
        Assert.Equal(@"namespace Test
{
    public struct Test2
    {
    }
}", result);
    }
    
    [Fact, 
     Trait("Category", "Emitter"),
     Trait("Feature", "Namespaces"),
     Trait("Target Language", "C#")]
    public void MultipleMembersIntegration()
    {
        var syntax = Transform
        (
            new NamespaceSymbol
            (
                new IdentifierSymbol("Test", ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray.Create<TypeSymbol>
                (
                    new StructSymbol
                    (
                        TypeId.CreateNew(),
                        new IdentifierSymbol("Test2", ImmutableArray<ISymbolAnnotation>.Empty),
                        ImmutableArray<MemberSymbol>.Empty,
                        ImmutableArray<ISymbolAnnotation>.Empty
                    ),
                    new StructSymbol
                    (
                        TypeId.CreateNew(),
                        new IdentifierSymbol("Test3", ImmutableArray<ISymbolAnnotation>.Empty),
                        ImmutableArray<MemberSymbol>.Empty,
                        ImmutableArray<ISymbolAnnotation>.Empty
                    )
                ),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        );

        var result = syntax.ToFullString();
        Assert.Equal(@"namespace Test
{
    public struct Test2
    {
    }
    public struct Test3
    {
    }
}", result);
    }
}

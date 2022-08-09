// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public sealed class TypeScopeSymbolVisitorTests
{
    [Fact, Trait("Category", "Type Resolution")]
    public void RootScopeContainsSingleRootType()
    {
        var testType = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty);
        var visitor = new TypeScopeSymbolVisitor(new TypeStore());

        visitor.Visit(testType);

        var rootScope = visitor.RootScope;
        var single = Assert.Single(rootScope.ChildTypeScopes);
        Assert.StrictEqual(testType.Id, single.Key);
        var associatedScope = single.Value;
        Assert.Empty(associatedScope.ChildTypeScopes);
    }
    
    [Fact, Trait("Category", "Type Resolution")]
    public void RootScopeEmptyWithEmptyNamespace()
    {
        var @namespace = new NamespaceSymbol(new IdentifierSymbol(""), ImmutableArray<TypeSymbol>.Empty);
        var visitor = new TypeScopeSymbolVisitor(new TypeStore());

        visitor.Visit(@namespace);

        var rootScope = visitor.RootScope;
        Assert.Empty(rootScope.ChildTypeScopes);
    }
    
    [Fact, Trait("Category", "Type Resolution")]
    public void RootScopeContainsSingleNamespacedType()
    {
        var testType = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty);
        var @namespace = new NamespaceSymbol
        (
            new IdentifierSymbol(""),
            new[]
            {
                (TypeSymbol) testType
            }.ToImmutableArray()
        );
        var visitor = new TypeScopeSymbolVisitor(new TypeStore());

        visitor.Visit(@namespace);

        var rootScope = visitor.RootScope;
        var single = Assert.Single(rootScope.ChildTypeScopes);
        Assert.StrictEqual(testType.Id, single.Key);
        var associatedScope = single.Value;
        Assert.Empty(associatedScope.ChildTypeScopes);
    }
    
    [Fact, Trait("Category", "Type Resolution")]
    public void RootScopeContainsMultipleNamespacedTypes()
    {
        var testType1 = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol("T1"), ImmutableArray<FieldSymbol>.Empty);
        var testType2 = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol("T2"), ImmutableArray<FieldSymbol>.Empty);
        var testType3 = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol("T3"), ImmutableArray<FieldSymbol>.Empty);
        var @namespace = new NamespaceSymbol
        (
            new IdentifierSymbol(""),
            new TypeSymbol[]
            {
                testType1,
                testType2,
                testType3
            }.ToImmutableArray()
        );
        var visitor = new TypeScopeSymbolVisitor(new TypeStore());

        visitor.Visit(@namespace);

        var rootScope = visitor.RootScope;
        Assert.Collection
        (
            rootScope.ChildTypeScopes,
            (kv) =>
            {
                Assert.StrictEqual(testType1.Id, kv.Key);
                var associatedScope = kv.Value;
                Assert.Empty(associatedScope.ChildTypeScopes);
            },
            (kv) =>
            {
                Assert.StrictEqual(testType2.Id, kv.Key);
                var associatedScope = kv.Value;
                Assert.Empty(associatedScope.ChildTypeScopes);
            },
            (kv) =>
            {
                Assert.StrictEqual(testType3.Id, kv.Key);
                var associatedScope = kv.Value;
                Assert.Empty(associatedScope.ChildTypeScopes);
            }
        );
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using System.ComponentModel;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests;

public class TypeStoreTests
{
    [Fact, Trait("Category", "Symbols"), Trait("Category", "TypeStore")]
    public void EmptyStoreDoesNotResolve()
    {
        var store = new TypeStore();
        
        var result = store.TryResolve(TypeId.CreateNew(), out var ts);
        
        Assert.False(result);
        Assert.Null(ts);
    }
    
    [Fact, Trait("Category", "Symbols"), Trait("Category", "TypeStore")]
    public void StoreResolvesSingleEntry()
    {
        var store = new TypeStore();
        var typeSymbol = new StructSymbol
            (TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty);
        store.Store(typeSymbol);
        
        var result = store.TryResolve(typeSymbol.Id, out var ts);
        
        Assert.True(result);
        Assert.StrictEqual(typeSymbol, ts);
    }
    
    [Fact, Trait("Category", "Symbols"), Trait("Category", "TypeStore")]
    public void StoreResolvesMultipleEntries()
    {
        var store = new TypeStore();
        var typeSymbol1 = new StructSymbol
            (TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty);
        store.Store(typeSymbol1);
        var typeSymbol2 = new StructSymbol
            (TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty);
        store.Store(typeSymbol2);
        
        var result1 = store.TryResolve(typeSymbol1.Id, out var ts1);
        var result2 = store.TryResolve(typeSymbol2.Id, out var ts2);
        
        Assert.True(result1);
        Assert.StrictEqual(typeSymbol1, ts1);
        Assert.True(result2);
        Assert.StrictEqual(typeSymbol2, ts2);
    }
}

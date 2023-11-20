// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.SilkTouch.Tests.Common;
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

    public static IEnumerable<object[]> BogusData => Enumerable.Range(0, Fakers.StandardGenerateCount)
        .Select(x => Fakers.TypeSymbol.Generate(x).ToArray())
        .Select(x => new[] { (object) x });
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"), Trait("Category", "TypeStore")]
    public void StoreResolvesEntries(TypeSymbol[] symbols)
    {
        var store = new TypeStore();
        foreach (var symbol in symbols)
        {
            store.Store(symbol);
        }

        foreach (var symbol in symbols)
        {
            Assert.True(store.TryResolve(symbol.Id, out var t1));
            Assert.StrictEqual(symbol, t1);
        }
    }
}

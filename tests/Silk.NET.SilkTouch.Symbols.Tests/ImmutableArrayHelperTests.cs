// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests;

public class ImmutableArrayHeloperTests
{
    [Fact]
    public void ReplaceOrAddRemovesAllOccurences()
    {
        var source = ImmutableArray.Create(5, 3, 2, 2);
        var result = source.ReplaceOrAdd(x => x == 2, 8);
        Assert.Equal(new[] { 5, 3, 8 }, result);
    }
}

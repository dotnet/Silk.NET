// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public sealed class EmitterFieldIntegrationTests : EmitterTest
{
    [Fact]
    public void StructHasStructKeyword()
    {
        var syntax = Transform(new FieldSymbol(new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<MemberSymbol>.Empty), new IdentifierSymbol("Test")));

        var result = syntax.ToFullString();
        Assert.Equal("public int Test;", result);
    }
}

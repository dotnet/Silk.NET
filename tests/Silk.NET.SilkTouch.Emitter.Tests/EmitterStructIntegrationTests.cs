// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public sealed class EmitterStructIntegrationTests : EmitterTest
{
    [Fact]
    public void StructHasStructKeyword()
    {
        var emitter = CreateEmitter();

        var symbol = new StructSymbol(new IdentifierSymbol("Test"));

        var syntax = emitter.Transform(symbol);

        var result = syntax.ToFullString();
        Assert.Equal("public struct Test{}", result);
    }
}

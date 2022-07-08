// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests;

public class ExternalTypeReferenceTests
{
    [Theory]
    [InlineData("N1", "T1", "global::N1.T1"), InlineData(null, "T1", "T1"), InlineData(null, "int", "int"),
     InlineData("System", "Int32", "global::System.Int32")]
    [Trait("Category", "Symbols")]
    public void ProducesCorrectFullType(string? @namespace, string type, string expected)
    {
        Assert.Equal
        (
            expected,
            new ExternalTypeReference
                (@namespace is null ? null : new IdentifierSymbol(@namespace), new IdentifierSymbol(type)).FullType
        );
    }
}

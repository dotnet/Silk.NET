// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class UnresolvedTypeReferenceTests
{
    [Fact, Trait("Category", "Symbols")]
    public void VisitingUnresolvedRefThrows()
    {
        var symbol = new ExternalTypeReference(null, new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        Assert.Throws<InvalidOperationException>(() => visitor.Object.Visit(symbol));
    }
}

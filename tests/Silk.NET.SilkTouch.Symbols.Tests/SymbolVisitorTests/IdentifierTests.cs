// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class IdentifierTests
{

    [Fact,
     Trait("Category", "Symbols")]
    public void IdentifierIsVisitedAsIdentifier()
    {
        var symbol = new IdentifierSymbol("");
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Once(), ItExpr.IsAny<IdentifierSymbol>());
    }
}

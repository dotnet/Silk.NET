// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class IdentifierTests
{
    public static IEnumerable<object[]> BogusData => Fakers.IdentifierSymbol.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });

    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void IdentifierIsVisitedAsIdentifier(IdentifierSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Once(), ItExpr.IsAny<IdentifierSymbol>());
    }
}

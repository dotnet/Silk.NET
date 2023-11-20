// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class StaticExternalMethodSymbolTests
{
    public static IEnumerable<object[]> BogusData => Fakers.StaticExternalMethodSymbol.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });
    
    [Theory, MemberData(nameof(BogusData)), Trait("Category", "Symbols")]
    public void VisitedAsSelf(StaticExternalMethodSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<StaticExternalMethodSymbol>
                ("VisitStaticExternalMethod", Times.Once(), ItExpr.IsAny<StaticExternalMethodSymbol>());
    }
    
    [Theory, MemberData(nameof(BogusData)), Trait("Category", "Symbols")]
    public void VisitedAsMethod(StaticExternalMethodSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<MethodSymbol>
                ("VisitMethod", Times.Once(), ItExpr.IsAny<MethodSymbol>());
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class ExternalTypeReferenceTests
{
    public static IEnumerable<object[]> BogusData => Fakers.ExternalTypeReference.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });

    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void RefIsVisitedAsRef(ExternalTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<ExternalTypeReference>("VisitExternalTypeReference", Times.Once(), ItExpr.IsAny<ExternalTypeReference>());
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void RefIsVisitedAsGenericRef(ExternalTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<TypeReference>("VisitTypeReference", Times.Once(), ItExpr.IsAny<TypeReference>());
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void RefTypeIdentifierIsVisitedAsIdentifier(ExternalTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<IdentifierSymbol>
            (
                "VisitIdentifier",
                Times.Once(),
                ItExpr.Is<IdentifierSymbol>(x => ReferenceEquals(x, symbol.TypeIdentifier))
            );
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void RefNamespaceIsVisitedAsIdentifier(ExternalTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<IdentifierSymbol>
            (
                "VisitIdentifier",
                symbol.Namespace is null ? Times.Never() : Times.Once(),
                ItExpr.Is<IdentifierSymbol>(x => ReferenceEquals(x, symbol.Namespace))
            );
    }
}

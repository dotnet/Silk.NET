// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class FieldTests
{
    public static IEnumerable<object[]> BogusData => Fakers.FieldSymbol.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldIsVisitedAsField(FieldSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<FieldSymbol>("VisitField", Times.Once(), ItExpr.IsAny<FieldSymbol>());
    }

    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldIsVisitedAsMember(FieldSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<MemberSymbol>("VisitMember", Times.Once(), ItExpr.IsAny<MemberSymbol>());
    }

    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldTypeIsVisited(FieldSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.Is<TypeReference>(x => ReferenceEquals(x, symbol.Type)));
    }

    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldIdentifierIsVisited(FieldSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<IdentifierSymbol>
            (
                "VisitIdentifier",
                Times.Once(),
                ItExpr.Is<IdentifierSymbol>(x => ReferenceEquals(x, symbol.Identifier))
            );
    }
}

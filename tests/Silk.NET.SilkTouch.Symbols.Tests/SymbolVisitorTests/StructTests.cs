// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class StructTests
{
    public static IEnumerable<object[]> BogusData => Fakers.StructSymbol.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });  
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs")]
    public void StructSymbolIsVisitedAsType(StructSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<TypeSymbol>("VisitType", Times.Once(), ItExpr.IsAny<TypeSymbol>());
    }

    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs")]
    public void StructSymbolIsVisitedAsStruct(StructSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<StructSymbol>("VisitStruct", Times.Once(), ItExpr.IsAny<StructSymbol>());
    }

    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs")]
    public void StructIdentifierIsVisitedAsIdentifier(StructSymbol symbol)
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
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields")]
    public void StructFieldsAreVisited(StructSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        foreach (var v in symbol.Members)
        {
            visitor.Protected()
                .Verify<FieldSymbol>("VisitField", Times.Once(), ItExpr.Is<FieldSymbol>(x => ReferenceEquals(x, v)));
        }
    }
}

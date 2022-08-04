// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class FieldTests
{
    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldIsVisitedAsField()
    {
        var symbol = new FieldSymbol(new ExternalTypeReference(null, new IdentifierSymbol("")), new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<FieldSymbol>("VisitField", Times.Once(), ItExpr.IsAny<FieldSymbol>());
    }

    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldIsVisitedAsMember()
    {
        var symbol = new FieldSymbol(new ExternalTypeReference(null, new IdentifierSymbol("")), new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<MemberSymbol>("VisitMember", Times.Once(), ItExpr.IsAny<MemberSymbol>());
    }

    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldTypeIsVisited()
    {
        var symbol = new FieldSymbol(new ExternalTypeReference(null, new IdentifierSymbol("")), new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Exactly(2), ItExpr.IsAny<IdentifierSymbol>());
    }

    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldIdentifierIsVisited()
    {
        var symbol = new FieldSymbol(new ExternalTypeReference(null, new IdentifierSymbol("")), new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>
                ("VisitIdentifier", Times.Exactly(1), ItExpr.Is<IdentifierSymbol>(x => object.ReferenceEquals(x, symbol.Identifier)));
    }
}

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
        var symbol = new FieldSymbol(new StructSymbol(new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty), new IdentifierSymbol(""));
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
        var symbol = new FieldSymbol(new StructSymbol(new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty), new IdentifierSymbol(""));
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
        var symbol = new FieldSymbol(new StructSymbol(new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty), new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<TypeSymbol>("VisitType", Times.Once(), ItExpr.IsAny<TypeSymbol>());
    }

    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Fields")]
    public void FieldIdentifierIsVisited()
    {
        var symbol = new FieldSymbol(new StructSymbol(new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty), new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        // note that this also tests whether the struct identifier is visited, there's just no good way of testing JUST the field identifier
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Exactly(2), ItExpr.IsAny<IdentifierSymbol>());
    }
}

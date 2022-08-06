// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Immutable;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class StructTests
{
    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs")]
    public void StructSymbolIsVisitedAsType()
    {
        var symbol = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty);
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<TypeSymbol>("VisitType", Times.Once(), ItExpr.IsAny<TypeSymbol>());
    }

    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs")]
    public void StructSymbolIsVisitedAsStruct()
    {
        var symbol = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty);
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<StructSymbol>("VisitStruct", Times.Once(), ItExpr.IsAny<StructSymbol>());
    }

    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs")]
    public void StructIdentifierIsVisitedAsIdentifier()
    {
        var symbol = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty);
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Once(), ItExpr.IsAny<IdentifierSymbol>());
    }

    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields")]
    public void StructFieldIsVisited()
    {
        var member = new FieldSymbol(new ExternalTypeReference(null, new IdentifierSymbol("int")), new IdentifierSymbol("Test1"));
        var symbol = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol("Test"), new[]
        {
            member
        }.ToImmutableArray());
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<FieldSymbol>("VisitField", Times.Once(), ItExpr.Is<FieldSymbol>(x => x == member));
    }


    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields")]
    public void StructFieldsAreVisited()
    {
        var member1 = new FieldSymbol(new ExternalTypeReference(null, new IdentifierSymbol("int")), new IdentifierSymbol("Test1"));
        var member2 = new FieldSymbol(new ExternalTypeReference(null, new IdentifierSymbol("int")), new IdentifierSymbol("Test2"));
        var symbol = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol("Test"), new[]
        {
            member1, member2
        }.ToImmutableArray());
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<FieldSymbol>("VisitField", Times.Once(), ItExpr.Is<FieldSymbol>(x => x == member1));
        
        visitor.Protected()
            .Verify<FieldSymbol>("VisitField", Times.Once(), ItExpr.Is<FieldSymbol>(x => x == member2));
    }
}

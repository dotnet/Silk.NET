// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class ClassSymbolTests
{
    [Fact, Trait("Category", "Symbols")]
    public void IsVisitedAsSelf()
    {
        var symbol = new ClassSymbol(TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<MethodSymbol>.Empty);
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<ClassSymbol>("VisitClass", Times.Once(), ItExpr.IsAny<ClassSymbol>());
    }
    
    [Fact, Trait("Category", "Symbols")]
    public void IsVisitedAsType()
    {
        var symbol = new ClassSymbol(TypeId.CreateNew(), new IdentifierSymbol(""), ImmutableArray<MethodSymbol>.Empty);
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<TypeSymbol>("VisitType", Times.Once(), ItExpr.IsAny<TypeSymbol>());
    }
}

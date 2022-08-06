// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class ExternalTypeReferenceTests
{
    [Fact,
     Trait("Category", "Symbols")]
    public void RefIsVisitedAsRef()
    {
        var symbol = new ExternalTypeReference(null, new IdentifierSymbol(""));
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<ExternalTypeReference>("VisitExternalTypeReference", Times.Once(), ItExpr.IsAny<ExternalTypeReference>());
    }
    
    [Fact,
     Trait("Category", "Symbols")]
    public void RefIsVisitedAsGenericRef()
    {
        var symbol = new ExternalTypeReference(null, new IdentifierSymbol(""));
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<TypeReference>("VisitTypeReference", Times.Once(), ItExpr.IsAny<TypeReference>());
    }
    
    [Fact,
     Trait("Category", "Symbols")]
    public void RefTypeIdentifierIsVisitedAsIdentifier()
    {
        var symbol = new ExternalTypeReference(null, new IdentifierSymbol(""));
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Once(), ItExpr.IsAny<IdentifierSymbol>());
    }
    
    [Fact,
     Trait("Category", "Symbols")]
    public void RefNamespaceIsVisitedAsIdentifier()
    {
        var symbol = new ExternalTypeReference(new IdentifierSymbol(""), new IdentifierSymbol(""));
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Exactly(2), ItExpr.IsAny<IdentifierSymbol>());
    }
}

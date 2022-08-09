// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class InternalTypeReferenceTests
{
    [Fact, Trait("Category", "Symbols")]
    public void VisitedAsSelf()
    {
        var symbol = new InternalTypeReference(TypeId.CreateNew());
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<InternalTypeReference>
                ("VisitInternalTypeReference", Times.Once(), ItExpr.IsAny<InternalTypeReference>());
    }
    
    [Fact, Trait("Category", "Symbols")]
    public void VisitedAsParent()
    {
        var symbol = new InternalTypeReference(TypeId.CreateNew());
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.IsAny<TypeReference>());
    }
    
    
    [Fact, Trait("Category", "Symbols")]
    public void TypeIdIsVisited()
    {
        var id = TypeId.CreateNew();
        var symbol = new InternalTypeReference(id);
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected().Verify<TypeId>("VisitTypeId", Times.Once(), ItExpr.Is<TypeId>(x => x == id));
    }
}

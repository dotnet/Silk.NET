// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class PointerTypeReferenceTests
{
    [Fact, Trait("Category", "Symbols")]
    public void RefIsVisitedAsSelf()
    {
        var symbol = new PointerTypeReference(new InternalTypeReference(TypeId.CreateNew()));
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<PointerTypeReference>
                ("VisitPointerTypeReference", Times.Once(), ItExpr.IsAny<PointerTypeReference>());
    }
    
    [Fact, Trait("Category", "Symbols")]
    public void RefIsVisitedAsRef()
    {
        var symbol = new PointerTypeReference(new InternalTypeReference(TypeId.CreateNew()));
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.Is<TypeReference>(x => ReferenceEquals(x, symbol)));
    }
    
    [Fact, Trait("Category", "Symbols")]
    public void RefUnderlyingIsVisitedAsRef()
    {
        var underlying = new InternalTypeReference(TypeId.CreateNew());
        var symbol = new PointerTypeReference(underlying);
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.Is<TypeReference>(x => ReferenceEquals(x, underlying)));
    }
}

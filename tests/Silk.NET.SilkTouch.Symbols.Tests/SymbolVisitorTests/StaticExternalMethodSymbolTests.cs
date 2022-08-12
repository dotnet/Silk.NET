// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class StaticExternalMethodSymbolTests
{
    [Fact, Trait("Category", "Symbols")]
    public void VisitedAsSelf()
    {
        var symbol = new StaticExternalMethodSymbol
            (new InternalTypeReference(TypeId.CreateNew()), ImmutableArray<TypeReference>.Empty, new IdentifierSymbol(""));
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<StaticExternalMethodSymbol>
                ("VisitStaticExternalMethod", Times.Once(), ItExpr.IsAny<StaticExternalMethodSymbol>());
    }
    
    [Fact, Trait("Category", "Symbols")]
    public void VisitedAsMethod()
    {
        var symbol = new StaticExternalMethodSymbol
            (new InternalTypeReference(TypeId.CreateNew()), ImmutableArray<TypeReference>.Empty, new IdentifierSymbol(""));
        
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<MethodSymbol>
                ("VisitMethod", Times.Once(), ItExpr.IsAny<MethodSymbol>());
    }
}

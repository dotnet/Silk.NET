// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests;

public sealed class SymbolVisitorTests
{
    [Fact]
    public void StructSymbolIsVisitedAsType()
    {
        var symbol = new StructSymbol(new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<TypeSymbol>("VisitType", Times.Once(), ItExpr.IsAny<TypeSymbol>());
    }

    [Fact]
    public void StructSymbolIsVisitedAsStruct()
    {
        var symbol = new StructSymbol(new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<StructSymbol>("VisitStruct", Times.Once(), ItExpr.IsAny<StructSymbol>());
    }

    [Fact]
    public void StructIdentifierIsVisitedAsIdentifier()
    {
        var symbol = new StructSymbol(new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Once(), ItExpr.IsAny<IdentifierSymbol>());
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class NamespaceTests
{
    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Namespaces")]
    public void NamespaceIdentifierIsVisited()
    {
        var symbol = new NamespaceSymbol(new IdentifierSymbol(""), ImmutableArray<TypeSymbol>.Empty);
            
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Once(), ItExpr.IsAny<IdentifierSymbol>());
    }
    
    [Fact,
     Trait("Category", "Symbols"),
     Trait("Feature", "Namespaces"),
     Trait("Feature", "Structs")]
    public void NamespaceMemberIsVisited()
    {
        var symbol = new NamespaceSymbol(new IdentifierSymbol(""), new []
        {
            (TypeSymbol)new StructSymbol(new IdentifierSymbol(""), ImmutableArray<FieldSymbol>.Empty)
        }.ToImmutableArray());
            
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<StructSymbol>("VisitStruct", Times.Once(), ItExpr.IsAny<StructSymbol>());
    }
}

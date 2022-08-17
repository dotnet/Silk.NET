// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class NamespaceTests
{
    public static IEnumerable<object[]> BogusData => Fakers.NamespaceSymbol.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Namespaces")]
    public void NamespaceIdentifierIsVisited(NamespaceSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<IdentifierSymbol>
            (
                "VisitIdentifier",
                Times.Once(),
                ItExpr.Is<IdentifierSymbol>(x => ReferenceEquals(x, symbol.Identifier))
            );
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols"),
     Trait("Feature", "Namespaces"),
     Trait("Feature", "Structs")]
    public void NamespaceMemberIsVisited(NamespaceSymbol symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        foreach (var member in symbol.Types)
        {
            visitor.Protected()
                .Verify<TypeSymbol>
                    ("VisitType", Times.Once(), ItExpr.Is<TypeSymbol>(x => ReferenceEquals(x, member)));
        }
    }
}

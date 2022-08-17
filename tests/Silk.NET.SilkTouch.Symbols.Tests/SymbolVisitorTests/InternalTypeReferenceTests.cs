// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class InternalTypeReferenceTests
{
    public static IEnumerable<object[]> BogusData => Fakers.InternalTypeReference.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void VisitedAsSelf(InternalTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<InternalTypeReference>
                ("VisitInternalTypeReference", Times.Once(), ItExpr.IsAny<InternalTypeReference>());
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void VisitedAsParent(InternalTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.IsAny<TypeReference>());
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void TypeIdIsVisited(InternalTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected().Verify<TypeId>("VisitTypeId", Times.Once(), ItExpr.Is<TypeId>(x => x == symbol.ReferencedTypeId));
    }
}

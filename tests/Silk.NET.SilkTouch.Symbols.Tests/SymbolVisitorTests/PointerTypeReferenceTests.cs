// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class PointerTypeReferenceTests
{
    public static IEnumerable<object[]> BogusData => Fakers.PointerTypeReference.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void RefIsVisitedAsSelf(PointerTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<PointerTypeReference>
                ("VisitPointerTypeReference", Times.Once(), ItExpr.IsAny<PointerTypeReference>());
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void RefIsVisitedAsRef(PointerTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.Is<TypeReference>(x => ReferenceEquals(x, symbol)));
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void RefUnderlyingIsVisitedAsRef(PointerTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };

        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.Is<TypeReference>(x => ReferenceEquals(x, symbol.Underlying)));
    }
}

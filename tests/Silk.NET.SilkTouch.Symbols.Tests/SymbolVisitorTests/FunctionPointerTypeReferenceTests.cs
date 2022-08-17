// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Moq.Protected;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class FunctionPointerTypeReferenceTests
{
    public static IEnumerable<object[]> BogusData => Fakers.FunctionPointerTypeReference.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void VisitedAsSelf(FunctionPointerTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<FunctionPointerTypeReference>
                ("VisitFunctionPointerTypeReference", Times.Once(), ItExpr.IsAny<FunctionPointerTypeReference>());
    }
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void VisitedAsRef(FunctionPointerTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.Is<TypeReference>(x => ReferenceEquals(x, symbol)));
    }
}

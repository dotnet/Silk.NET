// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class FunctionPointerTypeReferenceTests
{
    [Fact, Trait("Category", "Symbols")]
    public void VisitedAsSelf()
    {
        var symbol = new FunctionPointerTypeReference(new InternalTypeReference(TypeId.CreateNew()), ImmutableArray<TypeReference>.Empty);
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<FunctionPointerTypeReference>
                ("VisitFunctionPointerTypeReference", Times.Once(), ItExpr.IsAny<FunctionPointerTypeReference>());
    }
    
    [Fact, Trait("Category", "Symbols")]
    public void VisitedAsRef()
    {
        var symbol = new FunctionPointerTypeReference(new InternalTypeReference(TypeId.CreateNew()), ImmutableArray<TypeReference>.Empty);
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        visitor.Object.Visit(symbol);

        visitor.Protected()
            .Verify<TypeReference>
                ("VisitTypeReference", Times.Once(), ItExpr.Is<TypeReference>(x => ReferenceEquals(x, symbol)));
    }
}

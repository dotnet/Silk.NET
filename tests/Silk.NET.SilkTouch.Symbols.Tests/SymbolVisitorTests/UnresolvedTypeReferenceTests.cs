// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Silk.NET.SilkTouch.Tests.Common;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class UnresolvedTypeReferenceTests
{
    public static IEnumerable<object[]> BogusData => Fakers.UnresolvedTypeReference.Generate(Fakers.StandardGenerateCount)
        .Select(x => new[] { (object)x });  
    
    [Theory,
     MemberData(nameof(BogusData)),
     Trait("Category", "Symbols")]
    public void VisitingUnresolvedRefThrows(UnresolvedTypeReference symbol)
    {
        var visitor = new Mock<MockSymbolVisitor> { CallBase = true };
        Assert.Throws<InvalidOperationException>(() => visitor.Object.Visit(symbol));
    }
}

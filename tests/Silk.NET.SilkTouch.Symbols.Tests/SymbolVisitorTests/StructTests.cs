// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class StructTests
{
    [Fact]
    public void StructSymbolIsVisitedAsType()
    {
        var symbol = new StructSymbol(new IdentifierSymbol(""), StructLayout.Empty);
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
        var symbol = new StructSymbol(new IdentifierSymbol(""), StructLayout.Empty);
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
        var symbol = new StructSymbol(new IdentifierSymbol(""), StructLayout.Empty);
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Once(), ItExpr.IsAny<IdentifierSymbol>());
    }

    [Fact]
    public void StructMemberIsVisited()
    {
        MemberSymbol member = new FieldSymbol(new StructSymbol(new IdentifierSymbol("int"), StructLayout.Empty), new IdentifierSymbol("Test1"));
        var symbol = new StructSymbol(new IdentifierSymbol("Test"), new StructLayout((new[]
        {
            new LayoutEntry(member, 0)
        }).ToImmutableArray()));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<MemberSymbol>("VisitMember", Times.Once(), ItExpr.Is<MemberSymbol>(x => x == member));
    }

    [Fact]
    public void StructMembersAreVisited()
    {
        MemberSymbol member1 = new FieldSymbol(new StructSymbol(new IdentifierSymbol("int"), StructLayout.Empty), new IdentifierSymbol("Test1"));
        MemberSymbol member2 = new FieldSymbol(new StructSymbol(new IdentifierSymbol("int"), StructLayout.Empty), new IdentifierSymbol("Test2"));
        var symbol = new StructSymbol(new IdentifierSymbol("Test"), new StructLayout((new[]
        {
            new LayoutEntry(member1, 0),
            new LayoutEntry(member2, 4)
        }).ToImmutableArray()));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<MemberSymbol>("VisitMember", Times.Once(), ItExpr.Is<MemberSymbol>(x => x == member1));
        
        visitor.Protected()
            .Verify<MemberSymbol>("VisitMember", Times.Once(), ItExpr.Is<MemberSymbol>(x => x == member2));
    }
}
